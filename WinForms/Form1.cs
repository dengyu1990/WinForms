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
            int year = DateTime.Now.Year;
            for (int i = year; i > 1980; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            cboMonth.Items.AddRange(new string[] { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" });
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            int day = 0;
            int year = Convert.ToInt32(cboYear.SelectedItem.ToString().TrimEnd('年'));
            int month = Convert.ToInt32(cboMonth.SelectedItem.ToString().TrimEnd('月'));
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    day = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) ? 29 : 28;
                    break;
                default:
                    day = 30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                cboDay.Items.Add(i + "日");
            }
        }
    }
}
