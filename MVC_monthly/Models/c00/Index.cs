using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_monthly.Models.c00
{
    public class Index
    {
        //幻燈片
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string IMAGE { get; set; }
        public string LINK { get; set; }
       
        //最新文章
        public int ID_2 { get; set; }
        public string TITLE_2 { get; set; }
        public string IMAGE_2 { get; set; }
        public string LINK_2 { get; set; }
        
        //猜你想看
        public int ID_3 { get; set; }
        public string TITLE_3 { get; set; }
        public string IMAGE_3 { get; set; }
        public string LINK_3 { get; set; }
    }
}