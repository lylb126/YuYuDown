using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuYuDown
{
    /// <summary>
    /// 错误提示以及固定信息
    /// </summary>
    public struct ErrorCode
    {
        public static string ErrorMsg => "煜煜，报错了联系老刘吧";
        public static string Caption => "老刘提示";
        public static string Success => "成功收到数据";
        public static string SelectNull => "煜煜，没有找到这个动漫";
        public static string SelectError => "煜煜,查询出错了";
        public static string IdNullMsg => "煜煜，报错了联系老刘吧";
        public static string FolderPathNull => "这个目录还没有被创建！你直接开始下载就好了";
        public static string DownSuccess => "煜煜，下载完成了";
        public static string DownError => "煜煜,下载出错啦";
        public static string DownImgError => "煜煜，下载图片出错啦。找老刘吧";
        public static string DownActionError => "煜煜,下载出错啦!找老刘吧!";
    } 

}
