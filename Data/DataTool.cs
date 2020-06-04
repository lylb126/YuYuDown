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
        private static string _fmPath =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings
            .Settings["_fmPath"].Value;
        /// <summary>
        /// 读取JSON数据
        /// </summary>
        /// <returns>返回List集合数据</returns>
        public static T ReadData<T>() where T : new()
        {
            ;
            //如果路径上有文件，就读取文件
            if (File.Exists(_fmPath))
            {
                //读取数据
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream file = File.Open(dataPath + _fmPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    return file.Length > 0 ? (T)bf.Deserialize(file) : new T();//default (T) 引用类型和值类型返回值不一样，default(T)引用类型为空，容易报错
                }
            }
            //如果没有文件，创建一个新的
            else
            {
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                }
                using (FileStream fs = new FileStream(dataPath+_fmPath, FileMode.CreateNew))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(String.Empty);  //这里是写入的内容             
                    sw.Flush();
                }
                return new T();
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
            if (File.Exists(dataPath + _fmPath))
            {
                File.Delete(dataPath + _fmPath);
            }
            using (FileStream file = File.Create(dataPath + _fmPath))
            {
                bf.Serialize(file, Dwdata);
            }
        }
    }
}
