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
        public string path;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.Filter = "文本文件|*.txt";
            ofd.ShowDialog();
            path = ofd.FileName;
            string line;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
                txtContent.AppendText(line);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(txtContent.Text);
            sw.Close();
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.WordWrap = !txtContent.WordWrap;
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            txtContent.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            txtContent.ForeColor = cd.Color;
        }


        

        

    }
}
