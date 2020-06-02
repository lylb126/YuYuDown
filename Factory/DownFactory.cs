using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuYuDown.Factory
{
    /// <summary>
    /// 下载器工厂类
    /// </summary>
   public abstract class DownFactory
    {
        public  ContainerControl form;
        /// <summary>
        /// 下载
        /// </summary>
        public abstract void Down();
        /// <summary>
        /// 开始爬取
        /// </summary>
        public abstract void Start();
        /// <summary>
        /// 结束爬取
        /// </summary>
        public abstract void End();
        /// <summary>
        /// 结束通知
        /// </summary>
        public abstract void Notice();
    }
}
