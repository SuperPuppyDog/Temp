using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongzhuLive.Common
{
    public class A_Model
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        public string type { get; set; }
        public string domain { get; set; }
        public int isSign { get; set; }
        public string verifiedInformation { get; set; }
        public string gameId { get; set; }
        public string gameName { get; set; }
        public int grade { get; set; }
        public float score { get; set; }
        public int id { get; set; }
        public object highlight { get; set; }
        public string relationshipStat { get; set; }
        public string nickname { get; set; }
        public string hostAvatar { get; set; }
        public int hostGrade { get; set; }
        public string covers { get; set; }
        public Live live { get; set; }
        public dynamic tags { get; set; }
    }

    public class Live
    {
        public bool isLive { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public int onlineCount { get; set; }
        public int timeSpan { get; set; }
        public int liveSourceType { get; set; }
        public int liveStreamType { get; set; }
        public int hrefType { get; set; }
        public int hrefRoomId { get; set; }
        public string snapshot { get; set; }
    }


    public class Model_Temp
    {
       public List<A_Model> items { get; set; }
        public int totalItems { get; set; }
    }
}
