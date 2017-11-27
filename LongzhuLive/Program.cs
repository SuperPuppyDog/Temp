using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            //bool signal;
            //Mutex mutex = new Mutex(true, Application.ProductName, out signal);
            //if (signal)
            //{
                _verify = new System.Threading.Timer((s) =>
                {
                    if (!Verify.VerifyUser())
                    {
                        MessageBox.Show($"试用到期时间:{new DateTime(2017, 11, 29, 0, 0, 0)},已到期，请联系开发者:448544937");
                        System.Environment.Exit(0);
                    }
                }, null, 0, 10000);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                //mutex.ReleaseMutex();//释放一次  
            //}
            //else
            //{
            //    MessageBox.Show(null, "有一个和本程序相同的应用程序已经在运行，请不要同时运行多个。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //   提示信息，可以删除。     
            //    System.Environment.Exit(0);//退出程序   
            //}
         
        }
    }


}
