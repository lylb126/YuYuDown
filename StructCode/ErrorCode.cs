using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace YuYuDown
{
    /// <summary>
    /// 错误提示以及固定信息
    /// </summary>
    public struct ErrorCode
    {
        /// <summary>
        /// 老刘提示
        /// </summary>
        public static string Caption => "老刘提示!!";
        /// <summary>
        ///  前置
        /// </summary>
        public static string Callstr => ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings
            .Settings["CallMsg"].Value;
        /// <summary>
        /// 煜煜,报错了联系老刘吧
        /// </summary>
        public static string ErrorMsg => $"{Callstr},报错了联系老刘吧";
        /// <summary>
        /// 煜煜,下载出错啦!找老刘吧!
        /// </summary>
        public static string NetWorkError => $"{Callstr},你看看是不是没联网!";
        /// <summary>
        /// 成功收到数据
        /// </summary>
        public static string Success => "成功收到数据";
        /// <summary>
        /// 煜煜,没有找到这个动漫
        /// </summary>
        public static string SelectNull => $"{Callstr},没有找到这个动漫";
        /// <summary>
        /// 煜煜,查询出错了
        /// </summary>
        public static string SelectError => $"{Callstr},查询出错了";
        /// <summary>
        /// 煜煜,报错了联系老刘吧
        /// </summary>
        public static string IdNullMsg => $"{Callstr},报错了联系老刘吧";
        /// <summary>
        /// 这个目录还没有被创建！你直接开始下载就好了
        /// </summary>
        public static string FolderPathNull => $"{Callstr},这个目录还没有被创建！你直接开始下载就好了";
        /// <summary>
        /// 煜煜,下载完成了
        /// </summary>
        public static string DownSuccess => $"{Callstr},下载完成了";
        /// <summary>
        /// 煜煜,下载出错啦
        /// </summary>
        public static string DownError => $"{Callstr},下载出错啦";
        /// <summary>
        /// 煜煜,下载图片出错啦。找老刘吧
        /// </summary>
        public static string DownImgError => $"{Callstr},下载图片出错啦。找老刘吧";
        /// <summary>
        /// 煜煜,下载出错啦!找老刘吧!
        /// </summary>
        public static string DownActionError => $"{Callstr},下载出错啦!找老刘吧!";

    } 

}
