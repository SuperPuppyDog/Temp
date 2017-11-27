namespace LongzhuLive
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_room = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_game = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_online = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_spit = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_title = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_api = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_count_curret = new System.Windows.Forms.Label();
            this.num_pre = new System.Windows.Forms.NumericUpDown();
            this.cmb_ruls = new System.Windows.Forms.ComboBox();
            this.chk_line = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_pre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.Location = new System.Drawing.Point(12, 9);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(65, 12);
            this.lbl_room.TabIndex = 1;
            this.lbl_room.Text = "直播间地址";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(83, 6);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(376, 21);
            this.txt_url.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_name,
            this.toolStripStatusLabel2,
            this.lbl_game,
            this.toolStripStatusLabel3,
            this.lbl_online,
            this.toolStripStatusLabel4,
            this.lbl_time,
            this.lbl_spit,
            this.lbl_title});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_name
            // 
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lbl_game
            // 
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lbl_online
            // 
            this.lbl_online.Name = "lbl_online";
            this.lbl_online.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // lbl_time
            // 
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_spit
            // 
            this.lbl_spit.Name = "lbl_spit";
            this.lbl_spit.Size = new System.Drawing.Size(571, 17);
            this.lbl_spit.Spring = true;
            // 
            // lbl_title
            // 
            this.lbl_title.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(4, 17);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(75, 78);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(0, 12);
            this.lbl_count.TabIndex = 4;
            // 
            // txt_api
            // 
            this.txt_api.Location = new System.Drawing.Point(81, 42);
            this.txt_api.Multiline = true;
            this.txt_api.Name = "txt_api";
            this.txt_api.Size = new System.Drawing.Size(382, 48);
            this.txt_api.TabIndex = 5;
            this.txt_api.Text = "http://tvp.daxiangdaili.com/ip/?tid=555679969214890&num=100&filter=on";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "api链接：";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(14, 103);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_result.Size = new System.Drawing.Size(445, 189);
            this.txt_result.TabIndex = 6;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "当前UV";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(10, 159);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(132, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "目标UA:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(74, 32);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 12);
            this.lbl_status.TabIndex = 0;
            // 
            // lbl_count_curret
            // 
            this.lbl_count_curret.AutoSize = true;
            this.lbl_count_curret.Location = new System.Drawing.Point(74, 55);
            this.lbl_count_curret.Name = "lbl_count_curret";
            this.lbl_count_curret.Size = new System.Drawing.Size(11, 12);
            this.lbl_count_curret.TabIndex = 0;
            this.lbl_count_curret.Text = "0";
            // 
            // num_pre
            // 
            this.num_pre.Location = new System.Drawing.Point(71, 78);
            this.num_pre.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_pre.Name = "num_pre";
            this.num_pre.Size = new System.Drawing.Size(75, 21);
            this.num_pre.TabIndex = 1;
            // 
            // cmb_ruls
            // 
            this.cmb_ruls.FormattingEnabled = true;
            this.cmb_ruls.Items.AddRange(new object[] {
            "规则1",
            "规则2（吃鸡专用）"});
            this.cmb_ruls.Location = new System.Drawing.Point(6, 111);
            this.cmb_ruls.Name = "cmb_ruls";
            this.cmb_ruls.Size = new System.Drawing.Size(132, 20);
            this.cmb_ruls.TabIndex = 2;
            // 
            // chk_line
            // 
            this.chk_line.AutoSize = true;
            this.chk_line.Location = new System.Drawing.Point(10, 137);
            this.chk_line.Name = "chk_line";
            this.chk_line.Size = new System.Drawing.Size(84, 16);
            this.chk_line.TabIndex = 3;
            this.chk_line.Text = "刷取不在线";
            this.chk_line.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_line);
            this.groupBox1.Controls.Add(this.cmb_ruls);
            this.groupBox1.Controls.Add(this.num_pre);
            this.groupBox1.Controls.Add(this.lbl_count_curret);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(469, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 267);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据统计";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_api);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_room);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " DragonLive_448544937";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_pre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_name;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_game;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_online;
        private System.Windows.Forms.ToolStripStatusLabel lbl_spit;
        private System.Windows.Forms.ToolStripStatusLabel lbl_title;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txt_api;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_count_curret;
        private System.Windows.Forms.NumericUpDown num_pre;
        private System.Windows.Forms.ComboBox cmb_ruls;
        private System.Windows.Forms.CheckBox chk_line;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

