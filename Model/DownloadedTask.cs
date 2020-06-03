using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YuYuDown.Model.GetDrama;

namespace YuYuDown.Model
{
    /// <summary>
    /// 已下载
    /// </summary>
    public class DownloadedTask
    {
        /// <summary>
        /// 漫画ID
        /// </summary>
        public String DramaId { get; set; }
        /// <summary>
        /// 漫画名称
        /// </summary>
        public String DramaName { get; set; }
        /// <summary>
        /// 保存地址
        /// </summary>
        public String SaveAddress { get; set; }
        /// <summary>
        /// 下载时间
        /// </summary>
        public DateTime DownTime { get; set; }
        /// <summary>
        /// 漫画实体
        /// </summary>
        public Root FmModel { get; set; }
    }
}
