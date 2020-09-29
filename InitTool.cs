using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using YuYuDown.Common;
using YuYuDown.MQ;
using YuYuDown.SystemModel;

namespace YuYuDown
{
    static class InitTool
    {
        /// <summary>
        /// 执行初始化
        /// </summary>
        public static void StartInit()
        {
            CheckNetWorkStatus();
            CheckUpdate();
            InitMQ();
        }

        /// <summary>
        /// 检查更新
        /// </summary>
        static void CheckUpdate()
        {
            //检查网络状态
            if (CheckNetWork.CheckServeStatus() == false) MessageBox.Show(ErrorCode.NetWorkError, ErrorCode.Caption);
            //版本检测
            try
            {
                var version = JsonConvert.DeserializeObject<dynamic>(PostTool.Get("http://loocos.cn/YuYuDown/version.json"));
                Version newVersion = new Version(version.version.ToString());
                Version nowVersion = new Version(SytemVersion.AssemblyFileVersion.ToString());
                DialogResult updateResult = DialogResult.None;
                if (newVersion > nowVersion) updateResult = MessageBox.Show(@"是否进行更新？", @"更新提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //开始更新
                if (updateResult == DialogResult.OK)
                {
                    Console.WriteLine(@"开始更新");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"更新检查失败", @"更新提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.ErrorLog("更新失败", ex);
            }
        }

        /// <summary>
        /// 检查网络状态
        /// </summary>
        static void CheckNetWorkStatus()
        {
            //检查网络状态
            if (CheckNetWork.CheckServeStatus() == false) MessageBox.Show(ErrorCode.NetWorkError, ErrorCode.Caption);
        }
        /// <summary>
        ///    初始化消息队列
        /// </summary>
        static void InitMQ()
        {
            var messages = new MessageSend();
        }
    }
}
