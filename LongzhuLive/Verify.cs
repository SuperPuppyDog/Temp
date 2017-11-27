using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongzhuLive
{
    public class Verify
    {
        public static bool VerifyUser()
        {
            if (DateTime.Now >= new DateTime(2017, 11, 29, 0, 0, 0))
            {
                return false;
            }
            return true;
        }
    }
}
