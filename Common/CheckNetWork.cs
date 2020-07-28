using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace YuYuDown.Common
{
    /// <summary>
    /// 网络状态检测
    /// </summary>
   public static  class CheckNetWork
    {
        private static readonly string[] urls=new string[]{"www.baidu.com","www.sina.com","www.cnblogs.com","www.google.com","www.163.com","www.csdn.com" };
        /// <summary>
        /// 检测网络连接状态
        /// </summary>
        public static bool CheckServeStatus()
        {
            int errCount = 0;//ping时连接失败个数
            if (!LocalConnectionStatus())
            {
                LogHelper.WriteLog("网络异常~无连接");
                return false;
            }
            else if (!MyPing(out errCount))
            {
                if ((double)errCount / urls.Length >= 0.3)
                {

                    LogHelper.WriteLog("网络异常~连接多次无响应");
                    return false;
                }
                else
                {

                    LogHelper.WriteLog("网络不稳定");
                    return true;
                }
            }
            else
            {

                LogHelper.WriteLog("网络正常");
                return true;
            }
        }

       
        /// <summary>
        /// 调制解调器
        /// </summary>
        private const int INTERNET_CONNECTION_MODEM = 1;
        /// <summary>
        ///  网卡
        /// </summary>
        private const int INTERNET_CONNECTION_LAN = 2;
        [System.Runtime.InteropServices.DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);
        /// <summary>
        /// 判断本地的连接状态
        /// </summary>
        /// <returns></returns>
        private static bool LocalConnectionStatus()
        {
            Int32 dwFlag = new Int32();
            if (!InternetGetConnectedState(ref dwFlag, 0))
            {
                LogHelper.WriteLog("LocalConnectionStatus--未连网!");
                return false;
            }
            else
            {
                if ((dwFlag & INTERNET_CONNECTION_MODEM) != 0)
                {
                    LogHelper.WriteLog("LocalConnectionStatus--采用调制解调器上网。");
                    return true;
                }
                else if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
                {
                    LogHelper.WriteLog("LocalConnectionStatus--采用网卡上网。");
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Ping命令检测网络是否畅通
        /// </summary>
        /// <param name="urls">URL数据</param>
        /// <param name="errorCount">ping时连接失败个数</param>
        /// <returns></returns>
        private static bool MyPing(out int errorCount)
        {
            bool isconn = true;
            Ping ping = new Ping();
            errorCount = 0;
            try
            {
                PingReply pr;
                foreach (var str in urls)
                {
                    pr = ping.Send(str);
                    if (pr.Status != IPStatus.Success)
                    {
                        isconn = false;
                        errorCount++;
                    }

                    LogHelper.WriteLog($"Ping{str}——结果：{pr.Status}");
                }
            }
            catch
            {
                isconn = false;
                errorCount = urls.Length;
            }

            return isconn;
        }
    }
}
