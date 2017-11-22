using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongzhuLive.Common
{
   public class ChatModel
    {
        public string id { get; set; }
        public string type { get; set; }
        
        public Chat_Msg msg { get; set; }
    }

    public class Chat_Msg
    {
        public DateTime time { get; set; }
       
        public Msg_User user { get; set; }
        public int via { get; set; }
        public string content { get; set; }
        public int RoomId { get; set; }
        public string RoomDomain { get; set; }
    }

    public class Msg_User
    {
        public int uid { get; set; }
        public string username { get; set; }
        public int grade { get; set; }
        public int newGrade { get; set; }
        public string avatar { get; set; }
    }
}
