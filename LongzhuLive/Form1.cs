using LongzhuLive.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using ZD_Demo;

namespace LongzhuLive
{
    public partial class Form1 : Form
    {
        #region 初始化变量

        private static CancellationTokenSource clts_all = new CancellationTokenSource();
        
        public string _room_id;
        public object _lock = new object();
        public bool _b_flag = true;
        private static System.Threading.Timer _plusTimer;
        private static System.Threading.Timer _statusTimer;
        public int count_uas = 0;
        Action<NumericUpDown, bool> ac_Enable = (o, t) =>
        {
            o.Enabled = t;
        };
        Action<ToolStripStatusLabel, string> ac = (o, t) =>
        {
            o.Text = t;
        };
        Action<Label, string> ac_label = (o, t) =>
        {
            o.Text = t;
        };
        Action<TextBox, string> acText = (o, t) =>
        {
            o.Text += (t + "\r\n");
        };
        Func<TextBox, string> fc = (s) =>
        {
            return s.Text;
        };
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_api.Text))
            {
                MessageBox.Show("请填写api链接");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txt_url.Text) &&
                txt_url.Text.ToLower().Contains("longzhu.com"))
            {
                this._room_id = new Regex(@"http://star.longzhu.com/(\w+)").Match(txt_url.Text.Replace("?from=challcontent", "")).Groups[1].ToString();
                if (string.IsNullOrWhiteSpace(_room_id))
                {
                    MessageBox.Show("不能解析的房间号！");
                    return;
                }
                A_Model a_model = RoomRefresh(_room_id,cmb_ruls.SelectedIndex);
                lbl_name.Text = a_model.name;
                lbl_game.Text = a_model.gameName;
                lbl_title.Text = a_model.live.title;
                lbl_online.Text = a_model.live.isLive ? "正在直播" : "主播暂未直播!";
                lbl_time.Text = $"开播{a_model.live.timeSpan}分钟";
                lbl_status.Text = a_model.live.isLive ? "直播中" : "未直播"; a_model.live.onlineCount.ToString();
                if (!a_model.live.isLive && !chk_line.Checked) { MessageBox.Show("主播暂未直播，换个直播间吧！"); return; }

                if (_b_flag)
                {
                    acText.Invoke(txt_result, "即将开始……");
                    
                    #region 界面状态，主播是否直播
                    Task task_online = Task.Factory.StartNew(() =>
                    {
                        _statusTimer = new System.Threading.Timer(ss =>
                        {
                            A_Model model = new A_Model();
                            model = RoomRefresh(this._room_id, cmb_ruls.SelectedIndex);
                            if (!model.live.isLive&& !chk_line.Checked)
                            {
                                MessageBox.Show("主播已下线~");
                                _plusTimer.Change(-1, -1);
                                _statusTimer.Change(-1, -1);
                                btn_start.Text = "开始";
                                ac_Enable.Invoke(num_pre, true);
                                _b_flag = !_b_flag;
                                acText.Invoke(txt_result, "主播已下线，感谢使用_作者：448544937~");
                                clts_all.Cancel();
                                return;
                            }
                            ac_label.Invoke(lbl_status, model.live.isLive ? "直播中" : "未直播");
                            ac.Invoke(lbl_time, $"开播{model.live.timeSpan}分钟");
                        }, null, 0, 5000);
                    });
                    #endregion

                    #region has api
                    _plusTimer = new System.Threading.Timer(plus =>
                    {
                        Task<List<string>> taskIp = Task.Factory.StartNew<List<string>>(() => {
                            return GetIps(txt_api.Text);
                        });
                        taskIp.ContinueWith(s =>
                        {
                            List<string> myipslst = taskIp.Result;
                            if (myipslst != null && myipslst.Count > 0)
                            {
                                #region 处理UA
                                foreach (var item in myipslst)
                                {
                                    if (_b_flag) { break; }
                                    CancellationTokenSource clts = new CancellationTokenSource();
                                    Task tkUA = Task.Factory.StartNew(() =>
                                    {
                                        try
                                        {
                                            WebProxy proxy = new WebProxy();
                                            proxy.Address = new Uri($"http://{item}");
                                            HttpWebRequest reqest = WebRequest.Create(txt_url.Text) as HttpWebRequest;
                                            reqest.Accept = "*/*";
                                            reqest.KeepAlive = true;
                                            reqest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
                                           // reqest.Timeout = 3000;
                                            reqest.Proxy = proxy;
                                            reqest.AllowAutoRedirect = true;
                                            using (HttpWebResponse response = reqest.GetResponse() as HttpWebResponse)
                                            {
                                                count_uas += 1;
                                                #region 计算状态，达到目标后关闭

                                                ac_label.Invoke(lbl_count_curret, count_uas.ToString());
                                                if (count_uas >= num_pre.Value && num_pre.Value != 0)
                                                {
                                                    _plusTimer.Change(-1, -1);
                                                    _statusTimer.Change(-1, -1);
                                                    btn_start.Text = "开始";
                                                    ac_Enable.Invoke(num_pre, true);
                                                    acText.Invoke(txt_result, "已达到目标UV！停止运行，感谢使用_作者：448544937~");
                                                    _b_flag = !_b_flag;
                                                    clts_all.Cancel();
                                                    return;
                                                }
                                                #endregion
                                                clts.Cancel();
                                            };
                                            if (_b_flag) { clts.Cancel(); return; }
                                        }
                                        catch (Exception ex)
                                        {
                                            if (_b_flag) { clts.Cancel(); return; }
                                            acText.Invoke(txt_result, $"代理ip访问错误：{ex.Message}");
                                            clts.Cancel();
                                        }

                                    });
                                    acText.Invoke(txt_result, $"ip:{item},成功访问，等待响应……");
                                    tkUA.Wait();
                                    clts.Cancel();
                   
                                }
                                #endregion
                            }
                            else
                            {
                                acText.Invoke(txt_result, "获取ip失败！");
                                lock (_lock)
                                {
                                    ac.Invoke(lbl_title, string.Empty);
                                }
                                return;
                                //_plusTimer.Change(-1, -1);
                                //_statusTimer.Change(-1, -1);
                                //btn_start.Text = "开始";
                            }
                            //_plusTimer.Change(-1, -1);
                            //_statusTimer.Change(-1, -1);


                        });
                    },null,0,10000);
                    #endregion


                    lbl_count.Text = "";
                    btn_start.Text = "停止";
                    ac_Enable.Invoke(num_pre, false);

                }
                else
                {
                    lock (_lock)
                    {
                        ac.Invoke(lbl_title, string.Empty);
                    }
                    _plusTimer.Change(-1, -1);
                    _statusTimer.Change(-1, -1);
                    btn_start.Text = "开始";
                    ac_Enable.Invoke(num_pre, true);
                    acText.Invoke(txt_result, "停止运行，感谢使用_作者：448544937~");
                    clts_all.Cancel();
                }
                _b_flag = !_b_flag;

            }
            else
            {
                MessageBox.Show("直播链接不能为空，且只支持龙珠直播！");
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmb_ruls.SelectedIndex = 0;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public A_Model RoomRefresh(string room_Id,int select_rule)
        {
            
            if (select_rule == 0)
            {
                string downLoadData = Encoding.UTF8.GetString(new WebClient().DownloadData($"http://searchapi.plu.cn/api/search/room?title={room_Id}&pageSize=1"));
                Model_Temp tempModel = JsonConvert.DeserializeObject<Model_Temp>(downLoadData);
                return tempModel.items.FirstOrDefault<A_Model>();
            }
           else
            {
                string downLoadData = Encoding.UTF8.GetString(new WebClient().DownloadData($"http://searchapi.plu.cn/api/search/room?title={room_Id}"));
                Model_Temp tempModel = JsonConvert.DeserializeObject<Model_Temp>(downLoadData);
                if (tempModel.items.Count >= 2)
                {
                    return tempModel.items[1];
                }
            }
            return new A_Model();
        }

        public List<string> GetIps(string ip)
        {
            List<string> temp = new List<string>();
            try
            {
                string res = new WebClient().DownloadString(txt_api.Text);
                if (!res.ToLower().Contains("error"))
                {
                    temp.AddRange(res.Replace("\r\n", "\r").Split(new char[] { '\r' }));
                }

            }
            catch
            {

                temp = null;
            }
            return temp;
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            if (txt_result.Text.Length == int.MaxValue / 5)
            {
                txt_result.Invoke(new Action(() => { txt_result.Clear(); }));
            }
            this.txt_result.SelectionStart = this.txt_result.Text.Length;
            this.txt_result.SelectionLength = 0;
            this.txt_result.ScrollToCaret();
        }


      
    }
}
