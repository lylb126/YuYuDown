using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
using Newtonsoft.Json;
using YuYuDown.Data;
using YuYuDown.Factory;
using YuYuDown.Model;
using YuYuDown.Model.GetDrama;
using YuYuDown.Model.Getsound;
using YuYuDown.StructCode;

namespace YuYuDown.Common
{
    /// <summary>
    /// 下载器
    /// 保证单例模式
    /// sealed不可继承
    /// </summary>
    public sealed  class DownFm
    {
        /// <summary>
        /// 定义一个静态变量来保存类的实例
        /// volatile：可见性（线程之间的数据同步。保证都是最新的数据） 但未保证原子性（同一时刻只能有一个线程操作）、有序性（即程序执行的顺序按照代码的先后顺序执行）
        /// volatile：在使用时未能达到线程安全可使用Locker保证原子性以及有序性
        /// （Java）synchronized：可以实现线程安全
        /// </summary>
        private static volatile DownFm _uniqueInstance;
        /// <summary>
        ///   定义一个标识确保线程同步
        /// </summary>
        private static readonly object Locker = new object();
        /// <summary>
        /// 配置文件
        /// </summary>
        private static readonly AppSettingsSection Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings;
        /// <summary>
        /// 现在正在下载的任务列表
        /// </summary>
        public  Dictionary<DownloadedTask, bool> nowDownTask=new Dictionary<DownloadedTask, bool>();

        public static volatile DownloadedTask nowDowmFmModel;
        #region 窗体以及控件信息
        /// <summary>
        ///  更新的窗体
        /// </summary>
        public Form1 Form;
        /// <summary>
        ///  当前FM下载                 
        /// </summary>
        private SkinTextBox NowDown;

        /// <summary>
        ///  当前图片下载
        /// </summary>
        private SkinTextBox _imgDown;

        /// <summary>
        ///  图片进度条
        /// </summary>
        private SkinProgressBar _imgDwBar;

        /// <summary>
        ///  当前话进度条
        /// </summary>
        private SkinProgressBar DwprogressBar;
        /// <summary>
        ///  更新指定Form窗体
        /// </summary>
        /// <param name="action">无参数传入</param>
        private void UpdataForm(Action action) => Form.Invoke(action);
        #endregion
        #region 地址信息
        /// <summary>
        ///  获取获得FM作品地址
        /// </summary>
        string Getdrama;
        /// <summary>
        ///  获取单话地址
        /// </summary>
        string Getsound;
        /// <summary>
        /// 获取图片列表
        /// </summary>
        string Getimages;
        /// <summary>
        ///  获取图片前缀
        /// </summary>
        string ImagesAdress;

        public string Downstr;
        #endregion
        /// <summary>
        /// 定义私有构造函数，使外界不能创建该类实例
        /// </summary>
        private DownFm()
        {
            NowDown = Form.Controls.Find("nowDown", true).First() as SkinTextBox;
            _imgDown = Form.Controls.Find("ImgDown", true).First() as SkinTextBox;
            _imgDwBar = Form.Controls.Find("ImgDwBar", true).First() as SkinProgressBar;
            DwprogressBar = Form.Controls.Find("DwprogressBar", true).First() as SkinProgressBar;
            Getdrama = GetConfig("getdrama");
            Getsound = GetConfig("getsound");
            Getimages = GetConfig("getimages");
            ImagesAdress = GetConfig("imagesaddress");
            Downstr =Directory.GetCurrentDirectory() + "/"+GetConfig("SaveAddress");
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static DownFm GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            if (_uniqueInstance == null)
            {
                lock (Locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new DownFm();
                    }
                }
            }
            return _uniqueInstance;
        }

        /// <summary>
        ///   获取配置的Value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static  String GetConfig(String key) => Config.Settings[key].Value;
        /// <summary>
        /// 查询当前FM
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  Root Select(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            try
            {
                //获取FM当前小说下所有的话ID
                Root result = JsonConvert.DeserializeObject<Root>(PostTool.Post(Getdrama + id.Trim()));
                if (result.success)
                {
                    return result;
                }
                return null;
            }
            catch (Exception e)
            {
                LogHelper.ErrorLog(ErrorCode.SelectError, e);
                return null;
            }
        }

        /// <summary>
        ///  开始下载
        /// </summary>
        /// <param name="id">FM Id</param>
        public  void Start(string id)
        {
            
            try
            {
                //获取FM当前小说下所有的话ID
                Root result = Select(id);
                if (result.success)
                {
                    nowDowmFmModel = new DownloadedTask
                    {
                        DownTime = DateTime.Now,
                        DramaId = id,
                        DramaName = result.info.drama.name,
                        SaveAddress = Downstr + result.info.drama.name.Replace('/', ' '),
                        DwStatus = DwCode.DwReady
                    };
                    nowDownTask.Add(nowDowmFmModel, true);
                    GetMp3(result);
                }
            }
            catch (Exception e)
            {
                LogHelper.ErrorLog(ErrorCode.DownError, e);
                UpdataForm(() =>
                {
                    NowDown.Text = ErrorCode.DownError;
                });
                return;
            }
            //下载结束，进行通知
            UpdataForm(() =>
            {
             
                Form.Accomplish();
            });
           
            nowDowmFmModel.DwStatus = DwCode.Success;
            nowDownTask.Remove(nowDowmFmModel);
            JsonTool.SaveData(nowDowmFmModel);
            nowDowmFmModel = null;
        }
        public  void GetMp3(Root resultRoot)
        {
            foreach (var episode in resultRoot.info.episodes.episode)
            {
                //获取FM当前小说下所有的话ID
                RootGetdound result =
                    JsonConvert.DeserializeObject<RootGetdound>(PostTool.Post(Getsound + episode.sound_id));
                if (result.success)
                {
                    var filename = resultRoot.info.drama.name.Replace('/', ' ');
                    var directorypath = Downstr+ filename + "/" + episode.name;
                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }
                    UpdataForm(() =>
                    {
                        NowDown.Text = episode.name;
                    });
                    var t1 = new Task(() => GetImages(directorypath + "/Images", episode));
                    t1.Start();
                    DownloadFile(result.info.sound.soundurl, directorypath + "/" + episode.name + ".MP3"); //下载文件
                    Task.WaitAll(t1);//等待本轮任务结束   
                }
            }

        }

        public  void GetImages(string saveAddress, Episode episode)
        {
            if (!Directory.Exists(saveAddress))
            {
                Directory.CreateDirectory(saveAddress);
            }
            //获取FM当前小说的当前会话的所有图片
            RootImage result =JsonConvert.DeserializeObject<RootImage>(PostTool.Post(Getimages + episode.sound_id));
            if (result.success.Equals(ErrorCode.Success))
            {
                int current = 1;
                foreach (var item in result.successVal.images.OrderBy(s => s[5]))
                {
                    string filename = item[5] + "." + item.First().Split('.')[1];
                    if (filename.Contains("/"))
                    {
                        filename = filename.Remove(0, count: filename.LastIndexOf("/", StringComparison.Ordinal));
                        filename = filename.Replace("/", string.Empty);
                    }

                    DownloadImageFile(ImagesAdress + item.First(), saveAddress + "/" + filename); //下载文件
                    UpdataForm(() =>
                    {
                        _imgDwBar.Maximum = result.successVal.images.Count;
                        _imgDwBar.Value = current;
                        _imgDown.Text = $@"{episode.name} {_imgDwBar.Maximum}/{current}";
                        current++;
                    });
                }
            }
        }

        /// <summary>
        /// 下载文件(显示进度)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        public  void DownloadImageFile(string url, string filename)
        {
            Stream so = new FileStream(filename,FileMode.Create);
            Stream st = null;
            try
            {
                System.Net.HttpWebRequest myrq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                //等待五分钟
                myrq.Timeout = 300000;
                System.Net.HttpWebResponse myra = (System.Net.HttpWebResponse)myrq.GetResponse();
                st = myra.GetResponseStream();
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                if (st != null)
                {
                    int size = st.Read(by, 0, by.Length);
                    while (size > 0)
                    {
                        totalDownloadedByte = size + totalDownloadedByte;
                        Application.DoEvents();
                        so.Write(@by, 0, size);
                        size = st.Read(@by, 0, @by.Length);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.ErrorLog(ErrorCode.DownImgError, e);
                MessageBox.Show(ErrorCode.DownImgError, ErrorCode.Caption);

            }
            finally
            {
                so.Close();
                st?.Close();
            }
        }
        /// <summary>
        /// 下载文件(显示进度)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        public  void DownloadFile(string url, string filename)
        {
            Stream so = new FileStream(filename, FileMode.Create);
            Stream st =null;
            try
            {
                System.Net.HttpWebRequest myrq = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(url);
                myrq.Timeout= 180000;//等待三分钟
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse) myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                UpdataForm(()=>
                {
                    DwprogressBar.Maximum = (int) totalBytes;
                });
                st = myrp.GetResponseStream();
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                if (st != null)
                {
                    int size = st.Read(by, 0,  by.Length);
                    while (size > 0)
                    {
                        totalDownloadedByte = size + totalDownloadedByte;
                        Application.DoEvents();
                        so.Write(by, 0, size);
                        var downloadedByte = totalDownloadedByte;
                        UpdataForm(()=>
                        {
                            DwprogressBar.Value =(int)downloadedByte;
                        });
                        size = st.Read(by, 0,  by.Length);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.ErrorLog("下载出错啦", e);
                MessageBox.Show(ErrorCode.DownActionError, ErrorCode.Caption);
               
            }
            finally
            {
                so.Close();
                st?.Close();
            }
        }
    }
}
