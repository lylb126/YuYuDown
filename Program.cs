using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using YuYuDown.Common;
using YuYuDown.Data;
using YuYuDown.SystemModel;

namespace YuYuDown
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //检查网络状态
            if (CheckNetWork.CheckServeStatus()==false) MessageBox.Show(ErrorCode.NetWorkError, ErrorCode.Caption);
            //版本检测
            try
            {
                var version = JsonConvert.DeserializeObject<dynamic>(PostTool.Get("http://loocos.cn/YuYuDown/version.json"));
                Version newVersion = new Version(version.version.ToString());
                Version nowVersion = new Version(SytemVersion.AssemblyFileVersion.ToString());
                DialogResult updateResult = DialogResult.None;
                if (newVersion > nowVersion) updateResult=MessageBox.Show(@"是否进行更新？", @"更新提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //开始更新
                if (updateResult == DialogResult.OK)
                {
                    Console.WriteLine(@"开始更新");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"更新检查失败", @"更新提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.ErrorLog("更新失败",ex);
            }
            Application.Run(new Form1());
        }
    }
}
