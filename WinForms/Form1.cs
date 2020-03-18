using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程访问(非常不建议这样做)
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //前台线程：只有所有前台线程都关闭才算程序关闭
            //后台线程：只有前台线程结束后，后台线程自动结束
            //创建一个线程去执行该方法
            th = new Thread(Test);
            //标记这个线程准备就绪了，可以随时被执行（具体由CPU执行）
            th.IsBackground = true; //设置成后台线程
            th.Start();
            
        }

        private void Test()
        {
            for (int i = 0; i < 200000; i++)
            {
                //Console.WriteLine(i);
                lblDisplay.Text = i.ToString();
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null)
            {
                th.Abort();//手动结束这个线程
            }
        }
    }
}
