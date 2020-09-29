using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using YuYuDown.Common;
using YuYuDown.Data;
using YuYuDown.SystemModel;

namespace YuYuDown
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // init 初始化
            InitTool.StartInit();
            Application.Run(new Form1());
        }
    }
}
