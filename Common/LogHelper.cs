using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YuYuDown.Common
{
  public    class  LogHelper
    {
        /// <summary>
        ///  日志错误文件
        /// </summary>
        private LogHelper()
        {

        }

        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        /// <summary>
        ///  设置配置文件
        /// </summary>
        /// <param name="configFile"></param>
        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        /// <summary>
        ///  打印普通日志
        /// </summary>
        /// <param name="info"> 日志内容</param>
        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }
        /// <summary>
        /// 打印错误日志
        /// </summary>
        /// <param name="info">日志信息</param>
        /// <param name="se">引发的错误类型</param>
        public static void ErrorLog(string info, Exception se)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, se);
            }
        }
    }
}
