using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Thing thing = new Thing();
        private Person person = new Person();
        public Form1()
        {
            InitializeComponent();
            thing.UpData();
            person.CreateList();
            calculatePersonTotalMoney();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            ChangeData();
        }
        private void show()
        {
            
        }
        private void ChangeData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = person.SalesRecords;
            dataGridView2.DataSource = thing.ThingList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
        private void calculatePersonTotalMoney()
        {
            foreach(var item in person.SalesRecords)
            {
                foreach(var name in thing.NameList)
                {
                    item.TotalMoney += item.DicSearch[name] * thing.Pricelist[name];
                }
            }
        }
        private void caculateThingTotalMoney()
        {
            foreach (var item in thing.ThingList)
            {
                foreach (var name in item.NameList)
                {
                     
                }
            }
        }
    }
}
