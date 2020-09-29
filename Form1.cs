using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuYuDown.Model.GetDrama;
using CCWin;
using YuYuDown.Common;
using YuYuDown.FileDown;
using YuYuDown.MQ;

namespace YuYuDown
{
    public partial class Form1 : Skin_Mac
    {
        private MessageSend messageSend => MessageSend.messageSend;
        /// <summary>
        /// 下载器
        /// 单例模式
        /// </summary>
        private DownFm _downFm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //订阅消息
            subscribeEvent();
            LogHelper.WriteLog($"项目启动啦,时间:{DateTime.Now}");
            _downFm = DownFm.GetInstance();
            if (!Directory.Exists( _downFm.Downstr))
            {
                System.IO.Directory.CreateDirectory(_downFm.Downstr);
            }
        }
        /// <summary>
        /// 开始全部下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllDown(object sender, EventArgs e)
        {
            try
            {
                if (Idtext.Text.Equals(""))
                {
                    MessageBox.Show(ErrorCode.IdNullMsg, ErrorCode.Caption);
                }
                this.AllDwBt.Enabled = false;
                var t1 = new Task(() => _downFm.Start(Idtext.Text));
                t1.Start();
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(
                    ErrorCode.ErrorMsg + nameof(AllDown)
                    , ex);
                MessageBox.Show(ErrorCode.ErrorMsg, ErrorCode.Caption);
                this.AllDwBt.Enabled = true;
            }

        }
        /// <summary>
        /// 查询FM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select(object sender, EventArgs e)
        {
            //获取FM当前小说下所有的话ID
            Root result = _downFm.Select(Idtext.Text.Trim()) as Root;
            if (result == null)
            {
                AllDwBt.Enabled = false;
                MessageBox.Show(ErrorCode.SelectNull, ErrorCode.Caption);
                return;
            }
            AllDwBt.Enabled = true;
            ShowView.Items.Clear();
            ShowView.Items.AddRange(result.info.episodes.episode.OrderBy(s => s.id).Select(s => new ListViewItem() { ImageIndex = 1, Text = s.name, ToolTipText = s.soundstr })
                .ToArray());
            ShowView.EndUpdate();
            skinTextBox1.Text = result.info.drama.name;
            Newtext.Text = result.info.drama.newest;
            pictureBox1.WaitOnLoad = false;
            pictureBox1.LoadAsync(result.info.drama.cover);
        }


        /// <summary>
        ///  完成任务时调用
        /// </summary>
        public void Accomplish()
        {
            if (DwMusicCk.Checked)
            {
                clsMCI cm = new clsMCI();
                cm.FileName = GetApplicationPath() + "/Music/dingdong.mp3";
                cm.play();
            }
            AllDwBt.Enabled = true;
            //还可以进行其他的一些完任务完成之后的逻辑处理
            MessageBox.Show(ErrorCode.DownSuccess, ErrorCode.Caption);
        }
        /// <summary>
        ///  获取项目根目录
        /// </summary>
        /// <returns></returns>
        private static string GetApplicationPath()
        {
            return Environment.CurrentDirectory;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Idtext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.Select(sender, e);
            }
        }
        /// <summary>
        ///  打开本地下载目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDown_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(_downFm.Downstr))
            {
                MessageBox.Show(ErrorCode.FolderPathNull, ErrorCode.Caption);
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", _downFm.Downstr);
        }
        /// <summary>
        /// 订阅事件
        /// </summary>
        private void subscribeEvent()
        {
            //下载结束
            messageSend.SubscribeExecute("Accomplish", (datavalue) =>
            {
                Accomplish();
            });
            //更新下载小说名称
            messageSend.SubscribeExecute("Up_down_name", (datavalue) =>
            {
                nowDown.Text = datavalue["name"];
            });
            //更新总下载量
            messageSend.SubscribeExecute("Up_down_all", (datavalue) =>
            {
                ImgDwBar.Maximum = int.Parse(datavalue["imgDwBar_Maximum"]);
                ImgDwBar.Value = int.Parse(datavalue["imgDwBar_Value"]);
                ImgDown.Text = datavalue["name"];
            }); 
            //更新MP3下载
            messageSend.SubscribeExecute("Up_down_mp3", (datavalue) =>
            {
                DwprogressBar.Value = int.Parse(datavalue["DwprogressBar_Value"]);
            });
            //更新MP3下载总大小
            messageSend.SubscribeExecute("Up_down_mp3_Maximum", (datavalue) =>
            {
                DwprogressBar.Maximum = int.Parse(datavalue["DwprogressBar_Value"]);
            });
            //下载错误
            messageSend.SubscribeExecute("Up_down_error", (datavalue) =>
            {
                nowDown.Text = datavalue["error"];
            });
        }
    }
}
