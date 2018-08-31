using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string fileDir = Environment.CurrentDirectory;
            ml.Text ="当前目录"+ fileDir.ToString();


           

            //  string ystxt = fileDir + @"\settings.txt";
            //   File.Delete(ystxt);

            /*
            string ysm = fileDir + @"\settings.yaml";

            if (File.Exists(ysm))
            {
                StreamReader reader = new StreamReader(ysm, Encoding.Default);
                wbpz.Text = reader.ReadToEnd();
                reader.Close();
                
            }
            else
            {
                MessageBox.Show("老铁，没找到蓝灯配置文件啊，把我放在蓝灯根目录");
            }

            */





        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string fileDir = Environment.CurrentDirectory;
            string path1 = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string ysm = path1+ @"\Lantern\settings.yaml";

            if (proxyAll.Checked)
            {

            }


           // string ystxt = fileDir + @"\settings.txt";
           //  System.IO.File.Copy(ysm, ystxt);

                //  StreamReader reader = new StreamReader(ystxt, Encoding.Default);
                //  wbpz.Text = reader.ReadToEnd();

                string[] ary = File.ReadAllLines(ysm, Encoding.Default);
            ary[0] = "addr: "+http.Text+ ":" + port1.Text;//http ip 代理
            if (proxyAll.Checked == true)
            {
                ary[6] = "proxyAll: " + "true";//全局代理ON
            }
            else
            {
                ary[6] = "proxyAll: " + "false";//全局代理OFF
            }

            if (systemProxy.Checked == true)
            {
                ary[8] = "systemProxy: " + "true";//系统代理ON
            }
            else
            {
                ary[8] = "systemProxy: " + "false";//系统代理OFF
            }

            if (Launch.Checked == true)
            {
                ary[1] = "autoLaunch: " + "true";//开机启动ON
            }
            else
            {
                ary[1] = "autoLaunch: " + "false";//开机启动OFF
            }

            ary[7] = "socksAddr: "+socks .Text+ ":" + port2.Text;//socks ip 代理

            string str = string.Join("\r\n", ary);          
            File.WriteAllText(ysm, str);
            

            StreamReader reader = new StreamReader(ysm, Encoding.Default);
            wbpz.Text = reader.ReadToEnd();
            reader.Close();
            MessageBox.Show("lantern配置文件修改好咯");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string fileDir = Environment.CurrentDirectory;
            string path1 = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string exe = path1 + @"\Lantern\lantern.exe";


            if (File.Exists(exe))
            {
                Process pr = new Process();//声明一个进程类对象
                pr.StartInfo.FileName = exe;
                pr.Start();
                MessageBox.Show("已经配置完并启动蓝灯，注意右下角，可退出软件");
              //  System.Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("你真的装了lantern.exe？？？");
            }

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
          //  Url onedrive = new Url("https://1drv.ms/u/s!AlJF1mu_rRiSp-QsdCcvUtrHwZh7vw");

            System.Diagnostics.Process.Start("https://1drv.ms/u/s!AlJF1mu_rRiSp-QsdCcvUtrHwZh7vw");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pan.baidu.com/s/1lGtjHWjHyDKeq1bfBxytUg");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://getlantern.org/zh_CN/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/getlantern/forum#蓝灯lantern最新版本下载");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://weibo.com/lyf8989");
            
        }

        private void ml_Click(object sender, EventArgs e)
        {
            string fileDir = Environment.CurrentDirectory;
           // string path = @"D:\Program Files";
            System.Diagnostics.Process.Start("explorer.exe",ml.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            socks.Text = http.Text;
        }

        private void runcmd_Click(object sender, EventArgs e)
        {
            Cmd c = new Cmd();
            wbpz.Text = c.RunCmd(cmdBox.Text.Trim());
        }

        private void install_Click(object sender, EventArgs e)
        {
            string fileDir = Environment.CurrentDirectory;
            string path = fileDir+ @"\lantern_installer6.4.exe";
            //这里是要复制的地址
            try
            {
                File.WriteAllBytes(path, Resource1.lantern_installer);
                MessageBox.Show("软件安装包已经复制完成到当前目录，请安装");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ml.Text = path.ToString()+ @"\Lantern";
            System.Diagnostics.Process.Start("explorer.exe", ml.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string ysm = path + @"\Lantern\settings.yaml";

            if (File.Exists(ysm))
            {
                StreamReader reader = new StreamReader(ysm, Encoding.Default);
                wbpz.Text = reader.ReadToEnd();
                reader.Close();

            }
            else
            {
                MessageBox.Show("老铁，先安装蓝灯");
            }
        }
    }
}
