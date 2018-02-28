using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 業績計算
{
    public partial class Form1 : Form
    {
        private List<Person> personList = DataProcessing.UpdatedPerson();
        private List<Thing> thingList = DataProcessing.UpdatedThing();
        private List<string> nameList = DataProcessing.ThingName();
        private List<decimal> thingTotalMoney = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            thingTotalMoney = DataProcessing.ThingTotalMoney(personList,thingList);
            DataProcessing.CalculatePersonTotalMoney(personList,thingList);
            ChangeData();
        }
        private void ChangeData()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = personList;
            dataGridView2.DataSource = DataProcessing.DecimalToThing(thingTotalMoney);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in personList.Where(x => x.TotalMoney == personList.Max(y => y.TotalMoney)))
            {
                MessageBox.Show(item.PersonName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = thingTotalMoney.IndexOf(thingTotalMoney.Max());
            MessageBox.Show(nameList[index]);
        }
    }
}
