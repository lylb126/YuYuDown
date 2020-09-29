using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuYuDown.MQ
{
    /// <summary>
    ///   事件实体
    /// </summary>
    public class FuncModel
    {
        /// <summary>
        /// 方法ID
        /// </summary>
        public string FuncId => Guid.NewGuid().ToString();

        /// <summary>
        /// 方法名称
        /// </summary>
        public string FuncName { get; set; }

        /// <summary>
        /// 添加事件
        /// </summary>
        public DateTime AddDatetime => DateTime.Now;

        /// <summary>
        /// 方法
        /// </summary>
        public Action<Dictionary<string, string>> func { get; set; }

}
}
