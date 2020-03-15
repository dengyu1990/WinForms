﻿using System;
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
            string[] paths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\MM");
            lstPic.Items.AddRange(paths);
        }

        private void lstPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            picbDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            picbDisplay.Image = Image.FromFile(lstPic.SelectedItem.ToString());
        }
    }
}
