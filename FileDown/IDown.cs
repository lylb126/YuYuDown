using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuYuDown.FileDown
{
    /// <summary>
    ///  下载器接口
    /// </summary>
    interface IDown
    {
        Object Select(string id);
        void Start(string id);
        void End();
    }
}
