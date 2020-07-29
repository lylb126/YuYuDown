using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace YuYuDown.MQ
{
   public  class MessageSend
   {
        /// <summary>
        /// 事件注册
        /// </summary>
        private static Dictionary<string, Action<Dictionary<string, string>>> registerEvent = new Dictionary<string, Action<Dictionary<string, string>>>();
        /// <summary>
        ///  数据
        /// </summary>
        private static Dictionary<string, Dictionary<string, string>> dataValue=new Dictionary<string, Dictionary<string, string>>();
       /// <summary>
       ///   定义一个标识确保线程同步
       /// </summary>
       private static readonly object Locker = new object();
        /// <summary>
        /// 创建单利模式
        /// </summary>
        public static MessageSend messageSend { get; }
        static MessageSend()
        {
            if (messageSend == null)
            {
                lock (Locker)
                {
                    messageSend=messageSend ?? new MessageSend();
                }
            }
        }
        /// <summary>
        /// 订阅事件
        /// </summary>
        /// <param name="executeName">事件名称</param>
        /// <param name="action">执行动作</param>
        public void SubscribeExecute(string executeName, Action<Dictionary<string, string>> action)
        {
            registerEvent.Add(executeName, action);
            if (dataValue.ContainsKey(executeName))
            {
                registerEvent[executeName](dataValue[executeName]);//回调
            }
        }

        /// <summary>
        /// 注册事件信息
        /// </summary>
        /// <param name="executeName">事件名称</param>
        /// <param name="value">数据</param>
        public void RegisterAction(string executeName, Dictionary<string, string> value)
        {
            if (!string.IsNullOrEmpty(executeName) && value != null)
            {
                if (dataValue.ContainsKey(executeName))
                {
                    dataValue[executeName] = value;
                }
                else
                {
                    dataValue.Add(executeName, value);
                }
            }
            if (!string.IsNullOrEmpty(executeName) &&registerEvent.ContainsKey(executeName))
            {
                registerEvent[executeName](dataValue[executeName]);//回调
            }
        }

    }
}
