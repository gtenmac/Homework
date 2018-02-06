using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算幾個星期六星期日
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void isDays(int year)
        {
            DateTime dt = new DateTime(year, 1, 1);
            int Sundaycount = 0;
            int Saturdaycount = 0;
            for (int i = 0; i < dt.DayOfYear; i++)
            {
                switch (dt.DayOfWeek.ToString())
                {
                    case "Saturday":
                        Saturdaycount++;
                        break;
                    case "Sunday":
                        Sundaycount++;
                        break;
                    default:
                        break;
                }
                dt = dt.AddDays(1);
            }
            MessageBox.Show("Saturday " + Saturdaycount + ", Sunday " + Sundaycount);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            year = year < 1911 ? year + 1911 : year;
            isDays(year);
        }
    }
}
