using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace YuYuDown.SystemModel
{
    class SytemVersion
    {
        /// <summary>
        /// AssemblyVersion 程序集的版本例如 1.0.0.0 或 1.0.*
        /// </summary>
        public static Version AssemblyVersion
        {
            get { return ((Assembly.GetEntryAssembly()).GetName()).Version; }
        }
        /// <summary>
        /// AssemblyFileVersion 程序文件版本在文件属性中可以开到 例如 1.0.0.0
        /// </summary>
        public static Version AssemblyFileVersion
        {
            get { return new Version(FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion); }
        }
        /// <summary>
        /// AssemblyInformationalVersion 程序文件产品版本，格式可以自己定义例如 V1.0 Alpha
        /// </summary>
        public static string AssemblyInformationalVersion
        {
            get { return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductVersion; }
        }

    
    }
}
