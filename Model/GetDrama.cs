using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using YuYuDown.Model;

namespace YuYuDown.Model.GetDrama
{
    public class Tags
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
    }

    public class Drama
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// 吉缘-given-/GIVEN 被赠与的未来
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int integrity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cover { get; set; }

        /// <summary>
        /// 纯爱
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "checked")]
        public int Checked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int catalog { get; set; }

        /// <summary>
        /// 日文有声漫画
        /// </summary>
        public string catalog_name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool serialize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pay_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int need_pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Tags> tags { get; set; }

        /// <summary>
        /// 第 21 话
        /// </summary>
        public string newest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int organization_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string update_period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int view_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string organization { get; set; }
    }

    public class Episode
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int sound_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pay_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int need_pay { get; set; }

        /// <summary>
        /// 吉缘-given-code 0/ギヴン-given-
        /// </summary>
        public string soundstr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "checked")]
        public int Checked { get; set; }
    }

    public class Episodes
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> ft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> music { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Episode> episode { get; set; }
    }

    public class Cv_info
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// 齐藤壮马
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int group_id { get; set; }
    }

    public class Cvs
    {
        /// <summary>
        /// 佐藤真冬
        /// </summary>
        public string character { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Cv_info cv_info { get; set; }
    }

    public class Recommend
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 吉缘-given-/GIVEN 被赠与的未来
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string front_cover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "checked")]
        public int Checked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int police { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pay_type { get; set; }
    }

    public class Info
    {
        /// <summary>
        /// 
        /// </summary>
        public Drama drama { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int newest_episode_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Episodes episodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Cvs> cvs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int rewardable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> seasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int like { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string saw_episode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int saw_episode_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Recommend> recommend { get; set; }
    }
    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Info info { get; set; }
    }
}
