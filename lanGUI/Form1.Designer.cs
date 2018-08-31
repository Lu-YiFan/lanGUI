namespace lanGUI
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
            this.ml = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wbpz = new System.Windows.Forms.RichTextBox();
            this.http = new System.Windows.Forms.TextBox();
            this.port1 = new System.Windows.Forms.TextBox();
            this.socks = new System.Windows.Forms.TextBox();
            this.port2 = new System.Windows.Forms.TextBox();
            this.httpt = new System.Windows.Forms.Label();
            this.sockst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Launch = new System.Windows.Forms.CheckBox();
            this.proxyAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.systemProxy = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdBox = new System.Windows.Forms.TextBox();
            this.runcmd = new System.Windows.Forms.Button();
            this.install = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ml
            // 
            this.ml.AutoSize = true;
            this.ml.Location = new System.Drawing.Point(2, 6);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(29, 12);
            this.ml.TabIndex = 0;
            this.ml.Text = "目录";
            this.ml.Click += new System.EventHandler(this.ml_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wbpz
            // 
            this.wbpz.Location = new System.Drawing.Point(6, 212);
            this.wbpz.Name = "wbpz";
            this.wbpz.Size = new System.Drawing.Size(499, 190);
            this.wbpz.TabIndex = 2;
            this.wbpz.Text = "";
            // 
            // http
            // 
            this.http.Location = new System.Drawing.Point(67, 36);
            this.http.Name = "http";
            this.http.Size = new System.Drawing.Size(101, 21);
            this.http.TabIndex = 3;
            this.http.Text = "127.0.0.1";
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(174, 36);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(49, 21);
            this.port1.TabIndex = 4;
            this.port1.Text = "8787";
            // 
            // socks
            // 
            this.socks.Location = new System.Drawing.Point(67, 63);
            this.socks.Name = "socks";
            this.socks.Size = new System.Drawing.Size(101, 21);
            this.socks.TabIndex = 5;
            this.socks.Text = "127.0.0.1";
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(174, 63);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(49, 21);
            this.port2.TabIndex = 6;
            this.port2.Text = "10805";
            // 
            // httpt
            // 
            this.httpt.AutoSize = true;
            this.httpt.Location = new System.Drawing.Point(2, 39);
            this.httpt.Name = "httpt";
            this.httpt.Size = new System.Drawing.Size(53, 12);
            this.httpt.TabIndex = 7;
            this.httpt.Text = "HTTP地址";
            // 
            // sockst
            // 
            this.sockst.AutoSize = true;
            this.sockst.Location = new System.Drawing.Point(2, 66);
            this.sockst.Name = "sockst";
            this.sockst.Size = new System.Drawing.Size(59, 12);
            this.sockst.TabIndex = 8;
            this.sockst.Text = "SOCKS地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "是否开机启动：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "是否全局代理：";
            // 
            // Launch
            // 
            this.Launch.AutoSize = true;
            this.Launch.Location = new System.Drawing.Point(118, 134);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(36, 16);
            this.Launch.TabIndex = 15;
            this.Launch.Text = "是";
            this.Launch.UseVisualStyleBackColor = true;
            // 
            // proxyAll
            // 
            this.proxyAll.AutoSize = true;
            this.proxyAll.Location = new System.Drawing.Point(118, 164);
            this.proxyAll.Name = "proxyAll";
            this.proxyAll.Size = new System.Drawing.Size(36, 16);
            this.proxyAll.TabIndex = 16;
            this.proxyAll.Text = "是";
            this.proxyAll.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "是否代替系统代理：";
            // 
            // systemProxy
            // 
            this.systemProxy.AutoSize = true;
            this.systemProxy.Checked = true;
            this.systemProxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.systemProxy.Location = new System.Drawing.Point(118, 190);
            this.systemProxy.Name = "systemProxy";
            this.systemProxy.Size = new System.Drawing.Size(36, 16);
            this.systemProxy.TabIndex = 19;
            this.systemProxy.Text = "是";
            this.systemProxy.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 48);
            this.button2.TabIndex = 21;
            this.button2.Text = "启动蓝灯";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "将HTTP代理地址改为局域网IP，\r\nSOCKS用于游戏，同理。";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 431);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 12);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "百度云-分流下载";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "密码：hu6j";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(110, 405);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(71, 12);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "lantern官网";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(12, 405);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(89, 12);
            this.linkLabel4.TabIndex = 27;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "lantern-GitHub";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(184, 431);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(83, 12);
            this.linkLabel5.TabIndex = 28;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "@这是陆亦凡啊";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "2018.4.25";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 47);
            this.button3.TabIndex = 30;
            this.button3.Text = "相同";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdBox
            // 
            this.cmdBox.Location = new System.Drawing.Point(174, 95);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(236, 21);
            this.cmdBox.TabIndex = 31;
            this.cmdBox.Text = "ipconfig";
            // 
            // runcmd
            // 
            this.runcmd.Location = new System.Drawing.Point(174, 135);
            this.runcmd.Name = "runcmd";
            this.runcmd.Size = new System.Drawing.Size(121, 38);
            this.runcmd.TabIndex = 32;
            this.runcmd.Text = "CMD找IP";
            this.runcmd.UseVisualStyleBackColor = true;
            this.runcmd.Click += new System.EventHandler(this.runcmd_Click);
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(268, 409);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(117, 32);
            this.install.TabIndex = 33;
            this.install.Text = "释放-安装lantern";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(391, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 27);
            this.button4.TabIndex = 34;
            this.button4.Text = "飞到目录下";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 36);
            this.label3.TabIndex = 35;
            this.label3.Text = "先点击下面的安装lantern\r\n然后CMD找IP\r\n不修改IP直接启动蓝灯也可以翻墙";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.install);
            this.Controls.Add(this.runcmd);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.systemProxy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proxyAll);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sockst);
            this.Controls.Add(this.httpt);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.socks);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.http);
            this.Controls.Add(this.wbpz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "蓝灯-局域网&广域网共享配置-GUI-V1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ml;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox wbpz;
        private System.Windows.Forms.TextBox http;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.TextBox socks;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Label httpt;
        private System.Windows.Forms.Label sockst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Launch;
        private System.Windows.Forms.CheckBox proxyAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox systemProxy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cmdBox;
        private System.Windows.Forms.Button runcmd;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

