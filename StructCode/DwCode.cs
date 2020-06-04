using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuYuDown.StructCode
{
    /// <summary>
    /// 下载状态
    /// </summary>
    public struct  DwCode
    {
        /// <summary>
        ///    准备下载
        /// </summary>
        public static string DwReady => "准备下载";
        /// <summary>
        ///    下载中
        /// </summary>
        public static string Downing => "下载中";
        /// <summary>
        ///    已暂停
        /// </summary>
        public static string Stop => "已暂停";
        /// <summary>
        ///    已完成
        /// </summary>
        public static string Success => "已完成";
        /// <summary>
        ///    已取消
        /// </summary>
        public static string Cancel => "已取消";
    }
}
