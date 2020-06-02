using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace YuYuDown.Model.Getsound
{
    public class Sound
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int catalog_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int create_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int last_update_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// 包包大人
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cover_image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int animationid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int characterid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int seiyid { get; set; }
        /// <summary>
        /// 吉缘-given-code.2/ギヴン-given-【古川慎x齐藤壮马】
        /// </summary>
        public string soundstr { get; set; }
        /// <summary>
        /// <p>CAST：</p><p>佐藤真冬：斉藤壮馬</p><p>上ノ山立夏：古川慎</p><p>中山春樹：内匠靖明</p><p>梶秋彦：日野聡</p><p>村田雨月：田丸篤志</p><p>玄純/タケ：濱野大輝</p><p>鹿島柊：増田俊樹</p><p>板谷翔吾：榎木淳弥</p><p>植木：八代拓</p><p>笠井：本多真梨子</p><p>和果：大地葉</p><p>上ノ山弥生：矢作紗友里</p><p>【本声漫仅发布于M站，仅供试听交流，禁止转至其他网站，禁止二次上传】</p><p>【如有条件，请大家支持正版，有销量我们爱的老师才会有动力画出我们爱的作品】</p><p>※日版实体漫画及DRAMA CD购买地址</p><p>日亚：<span><a href="https://www.amazon.co.jp/">https://www.amazon.co.jp/</a></span></p><p>A店：<span><a href="https://www.animate-onlineshop.jp/">https://www.animate-onlineshop.jp/</a></span></p><p>comicomi：<span><a href="https://www.comicomi-studio.com/">https://www.comicomi-studio.com/</a></span></p><p>※也可寻找国内代购平台如玛莎多拉</p><p>※日版电子漫画购买地址：</p><p>日亚：<span><a href="https://www.amazon.co.jp/">https://www.amazon.co.jp/</a></span></p><p>Renta！：<span><a href="https://renta.papy.co.jp/">https://renta.papy.co.jp/</a></span></p><p>台版漫画可在微店购买，但由于最近有一些问题，台版漫画咱是无法购买</p>
        /// </summary>
        public string intro { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string soundurl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string soundurl_128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int downtimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uptimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int view_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int favorite_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int point { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int push { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int refined { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comments_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sub_comments_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pay_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "checked")]
        public int Checked { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int source { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int download { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string front_cover { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int all_comments { get; set; }
    /// <summary>
    /// 2.3 万
    /// </summary>
    public string view_count_formatted { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string videourl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int forbidden_comment { get; set; }
    /// <summary>
    /// <a target="_blank" href="/sound/m/41">日抓</a>&nbsp;&nbsp;&gt;&nbsp;&nbsp<a target="_blank" href="/sound/m/33">有声日漫</a>
    /// </summary>
    public string breadcrumb { get; set; }
}

public class Tags
{
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 齐藤壮马
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string icon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cover { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sintro { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string intro { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sound_num { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string image_num { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string album_num { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string follow_num { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string userid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string seiyid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string characterid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string animationid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sort_channel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string catalogid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string last_upload_time { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string recommended { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sort_type { get; set; }
}

public class User
{
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string intro { get; set; }
    /// <summary>
    /// 包包大人
    /// </summary>
    public string username { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string icon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string fansnum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int soundnum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int authenticated { get; set; }
}

public class Info
{
    /// <summary>
    /// 
    /// </summary>
    public Sound sound { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<Tags> tags { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public User user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int comment_count { get; set; }
}

public class RootGetdound
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
