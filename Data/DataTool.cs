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
   public static  class DataTool
    {
        private static string dataPath = Environment.CurrentDirectory+ "/data";
        /// <summary>
        /// 下载数据的保存地址
        /// </summary>
        private static string _jsonAddress =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings
            .Settings["_fmPath"].Value;
        /// <summary>
        /// 读取JSON数据
        /// </summary>
        /// <returns>返回List集合数据</returns>
        public static T ReadData<T>()
        {
            ;
            //如果路径上有文件，就读取文件
            if (File.Exists(_jsonAddress))
            {
                //读取数据
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream file = File.Open(dataPath + _jsonAddress, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    return file.Length > 0 ? (T)bf.Deserialize(file) : default(T);
                }
            }
            //如果没有文件，创建一个新的
            else
            {
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                }
                using (FileStream fs = new FileStream(dataPath+_jsonAddress, FileMode.CreateNew))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(String.Empty);  //这里是写入的内容             
                    sw.Flush();
                }
                return default(T);
            }
        }
        /// <summary>
        ///  保存下载记录
        /// </summary>
        /// <param name="Dwdata">下载记录</param>
        public static void SaveData(object Dwdata)
        {
            //保存数据      
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(dataPath + _jsonAddress))
            {
                File.Delete(dataPath + _jsonAddress);
            }
            using (FileStream file = File.Create(dataPath + _jsonAddress))
            {
                bf.Serialize(file, Dwdata);
            }
        }
    }
}
