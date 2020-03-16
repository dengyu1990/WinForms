using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "要打开的文本文件哦~";
            ofd.Multiselect = true; //可以多选
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.Filter = "文本文件|*.txt";
            ofd.ShowDialog();

            //获得打开对话框中选中文件的路径
            string line;
            StreamReader sr = new StreamReader(ofd.FileName);
            while ((line = sr.ReadLine()) != null)
            {
                txtContent.AppendText(line);
            }
        }
    }
}
