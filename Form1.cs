﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuYuDown.Model.GetDrama;
using YuYuDown.Model.Getsound;
using CCWin;
using YuYuDown.Common;
using System.Media;
using System.Runtime.InteropServices;

namespace YuYuDown
{
    public partial class Form1 : Skin_Mac
    {
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
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "/down"))
            {
                System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "/down");
            }
            LogHelper.WriteLog("项目启动啦");
            _downFm = DownFm.GetInstance();
            _downFm.Form = this;
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
                    MessageBox.Show("煜煜，请输入要下载的ID", ErrorCode.Caption);
                }

                this.AllDwBt.Enabled = false;
                var t1 = new Task(() => _downFm.Start(Idtext.Text));
                t1.Start();
            }
            catch (Exception exception)
            {
                LogHelper.ErrorLog("下载出错啦",exception);
                MessageBox.Show("煜煜，报错了联系老刘吧", ErrorCode.Caption);
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
            Root result = _downFm.Select(Idtext.Text.Trim());
            if (result == null)
            {
                AllDwBt.Enabled = false;
                MessageBox.Show("煜煜，没有找到这个动漫", ErrorCode.Caption);
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


        //完成任务时需要调用
        public void Accomplish()
        {
            if (DwMusicCk.Checked)
            {
                clsMCI cm = new clsMCI();
                cm.FileName = GetApplicationPath() + "/Music/dingdong.mp3";
                cm.play();
            }
            //还可以进行其他的一些完任务完成之后的逻辑处理
            MessageBox.Show("任务完成", ErrorCode.Caption);
        }
        /// <summary>
        ///  获取项目根目录
        /// </summary>
        /// <returns></returns>
        private static string GetApplicationPath()
        {
            //string path = Environment.CurrentDirectory.ToString();
            //string folderName = String.Empty;
            //while (folderName.ToLower() != "bin")
            //{
            //    path = path.Substring(0, path.LastIndexOf("\\"));
            //    folderName = path.Substring(path.LastIndexOf("\\") + 1);
            //}
            //return path.Substring(0, path.LastIndexOf("\\") + 1);
            return Environment.CurrentDirectory.ToString();
        }

        private void Idtext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.Select(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accomplish();
        }

        private void OpenDown_Click(object sender, EventArgs e)
        {
            string OpenFolderPath = Environment.CurrentDirectory.ToString()+"\\down";
            if (!Directory.Exists(OpenFolderPath))
            {
                MessageBox.Show("这个目录还没有被创建！你直接开始下载就好了", ErrorCode.Caption);
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", OpenFolderPath);
        }
    }
}
