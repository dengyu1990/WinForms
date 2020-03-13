using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"C:\Users\ms\Desktop\5.jpg");            
        }

        //获取文件夹下面所有文件的路径
        string[] paths = Directory.GetFiles(@"C:\Users\ms\Desktop\");

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i == paths.Length)
                i = 0;
            pictureBox1.Image = Image.FromFile(paths[i++]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (i < 0)
                i = paths.Length - 1;
            pictureBox1.Image = Image.FromFile(paths[i--]);
        }
    }
}
