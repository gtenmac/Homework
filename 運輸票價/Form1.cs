using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 運輸票價
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, decimal>> _dic = new Dictionary<string, Dictionary<string, decimal>>();
        public Form1()
        {
            _dic = DataProcess.ReadText();
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            checkBox1.Click += CheckBox1_Click;
            checkBox2.Click += CheckBox2_Click;
            ChangeData();
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            var money = _dic[Data.ComboBox1][Data.ComboBox2];
            if (!checkBox1.Checked && checkBox2.Checked)
            {
                Data.Money = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                CheckBox1AndCheckBox2(money);
            }
        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            var money = _dic[Data.ComboBox1][Data.ComboBox2];
            if (!checkBox2.Checked && checkBox1.Checked)
            {
                Data.Money = Math.Ceiling(money * Convert.ToDecimal(0.9));
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                CheckBox1AndCheckBox2(money);
            }
        }

        private void CheckBox1AndCheckBox2(decimal m)
        {
            Data.Money = Math.Ceiling(m * Convert.ToDecimal(0.81));
        }
        
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.ComboBox2 = Convert.ToString(comboBox2.SelectedItem);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.ComboBox1 = Convert.ToString(comboBox1.SelectedItem);
        }
        private void ChangeData()
        {
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
            comboBox1.DataSource = DataProcess.list1;
            comboBox2.DataSource = DataProcess.list2;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked) label4.Text = Convert.ToString(0);
            else label4.Text = Convert.ToString(Data.Money);
            ChangeData();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Data.CheckBox1 = true;
            else Data.CheckBox1 = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) Data.CheckBox2 = true;
            else Data.CheckBox2 = false;
        }
    }
}
