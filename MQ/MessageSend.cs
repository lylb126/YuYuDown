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
        private static Dictionary<string,List<FuncModel>> registerEvent = new Dictionary<string, List<FuncModel>>();
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
        /// 订阅消息
        /// </summary>
        /// <param name="executeName">事件名称</param>
        /// <param name="action">执行动作</param>
        public void SubscribeExecute(string executeName, Action<Dictionary<string,string>> action)
        {
            FuncModel funcModel=new FuncModel()
            {
                func = action,FuncName = executeName
            };
            if (registerEvent.ContainsKey(executeName))
            {
                registerEvent[executeName].Add(funcModel);
            }
            else registerEvent.Add(executeName,new List<FuncModel>(){ funcModel });
        }

        /// <summary>
        ///  发布消息
        /// </summary>
        /// <param name="executeName">事件名称</param>
        /// <param name="value">数据</param>
        public bool RegisterAction(string executeName, Dictionary<string, string> value)
        {
            registerEvent.TryGetValue(executeName, out List<FuncModel> func);
            if (func==null||func?.Count <= 0) return false;
            foreach (var itemFuncModel in func)
            {
                itemFuncModel.func(value);
            }
            return true;
        }

    }
}
