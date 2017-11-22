using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongzhuLive
{

    static class Program
    {

        private static System.Threading.Timer _verify;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            _verify = new System.Threading.Timer((s) =>
            {
                if (!Verify.VerifyUser())
                {
                    MessageBox.Show($"试用到期时间:{new DateTime(2017, 11, 25, 0, 0, 0)},已到期，请联系开发者:448544937");
                    System.Environment.Exit(0);
                }
            }, null, 0, 10000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
