using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test._frm1 = this;
        }

        private void 打开新窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 打开新窗口ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.MdiParent = this;
            frm.Show();


        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
