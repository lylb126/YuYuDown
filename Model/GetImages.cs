using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuYuDown.Model
{
   public class SuccessVal
    {
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> images { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> components { get; set; }
    }

    public class RootImage
    {
        /// <summary>
        /// 成功收到数据
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SuccessVal successVal { get; set; }
    }

}
