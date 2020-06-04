using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YuYuDown.Data;

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
            JsonData.ReadJsonData();
            Application.Run(new Form1());
        }
    }
}
