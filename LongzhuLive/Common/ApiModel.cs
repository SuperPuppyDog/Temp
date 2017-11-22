using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongzhuLive.Common
{
   public class ApiModel
    {
        public string ERRORCODE { get; set; }
        public List<Newip> RESULT { get; set; }
    }

    public class Newip
    {

        public string ip { get; set; }
        public  int port { get; set; }
    }
}
