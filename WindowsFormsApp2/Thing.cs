using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Thing
    {
        public string ThingName { get; set; }
        public decimal Money { get; set; }
        public decimal TotalMoney { get; set; }
        public List<string> NameList = new List<string>();
        public List<Thing> ThingList = new List<Thing>();
        public Dictionary<string, decimal> Pricelist = new Dictionary<string, decimal>();
        public void UpData()
        {
            string FileName = "Pricelist.txt";
            if (File.Exists(FileName))
            {
                foreach (var s in File.ReadLines(FileName))
                {
                    var i = s.Split(',');
                    var item = new Thing
                    {
                        ThingName = i[0],
                        Money = Convert.ToDecimal(i[1])
                    };
                    item.ThingList.Add(item);
                    item.Pricelist.Add(item.ThingName,item.Money);
                    item.NameList.Add(item.ThingName);
                }
            }
        }
    }
}
