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


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            //注意：不会给你默认加上http等前缀
            wbrower.Url = new Uri(@"http://" + txtURL.Text);
           
        }
    }
}
