using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using YuYuDown.Model;

namespace YuYuDown.Data
{
    /// <summary>
    /// 下载记录JSON数据
    /// </summary>
   public static  class JsonData
    {
        /// <summary>
        /// 下载数据的保存地址
        /// </summary>
        private static string _jsonAddress = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings
            .Settings["SaveDown"].Value;
        /// <summary>
        ///  
        /// </summary>
        public static List<DownloadedTask> Dwdata=new List<DownloadedTask>();
        /// <summary>
        /// 读取JSON数据
        /// </summary>
        /// <returns>返回List集合数据</returns>
        public static void ReadJsonData()
        {
            ;
            //如果路径上有文件，就读取文件
            if (File.Exists(_jsonAddress))
            {
                //读取数据
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(_jsonAddress, FileMode.Open);
                Dwdata = (List<DownloadedTask>)bf.Deserialize(file);
                file.Close();
            }
            //如果没有文件，创建一个新的
            else
            {
                Dwdata = new List<DownloadedTask>();
            }
        }
        /// <summary>
        ///  保存下载记录
        /// </summary>
        /// <param name="Dwdata">下载记录</param>
        public static void SaveJsonData(List<DownloadedTask> Dwdata)
        {
            //保存数据      
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(_jsonAddress))
            {
                File.Delete(_jsonAddress);
            }
            FileStream file = File.Create(_jsonAddress);
            bf.Serialize(file, Dwdata);
            file.Close();
        }
    }
}
