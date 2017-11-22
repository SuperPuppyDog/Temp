﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZD_Demo
{
    public class ZDHelper
    {
        public static string authHeader(String orderno, String secret)
        {
            int timestamp = ConvertDateTimeInt(DateTime.Now);

            //拼装签名字符串
            String planText = string.Format("orderno={0},secret={1},timestamp={2}", orderno, secret, timestamp);

            //计算签名
            String sign = GetMD5(planText);
            //拼装请求头Proxy-Authorization的值
            string authHeader = string.Format("sign={0}&orderno={1}&timestamp={2}", sign, orderno, timestamp);
            return authHeader;
        }

        /// <summary>
        /// 实际获取结果
        /// </summary>
        /// <returns></returns>
        public static string GetIpRes(string _orderNo, string _secret)
        {
            try
            {
                string res = string.Empty;
                string ip = "forward.xdaili.cn";
                //ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate; //https证书验证
                WebClient wc = new WebClient();
                wc.Headers.Add("Proxy-Authorization", authHeader(_orderNo, _secret));
                wc.Proxy = new WebProxy(ip, 80);

                res = wc.DownloadString("http://pv.sohu.com/cityjson");
                //res = wc.DownloadString("https://www.baidu.com/");
                return res;
            }
            catch 
            {
                return "";
            }
        }

        private static bool RemoteCertificateValidate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //总是返回true，相当于忽略证书验证
            return true;
        }

        /// <summary>
        /// 生成10位时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        /// <summary>
        /// 获取MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptedBytes = md5.ComputeHash(Encoding.Default.GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                sb.Append(encryptedBytes[i].ToString("x2"));
            }
            return sb.ToString().ToUpper();
        }
    }
}