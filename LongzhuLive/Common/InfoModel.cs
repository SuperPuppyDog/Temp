using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongzhuLive.Common
{
    //{"title":"听说今天过节？？？","online":"在线91204人",
    //"duration":"开播18分钟","game":"正在直播：王者荣耀","username":"Anni琳一"}
    public class InfoModel
    {
        public string title { get; set; }
        public string online { get; set; }
        public string duration { get; set; }
        public string game { get; set; }
        public string username { get; set; }
    }
}
