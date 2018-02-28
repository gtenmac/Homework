using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 業績計算
{
    class DataProcessing
    {
        static private List<string> NameList = new List<string>();
        static public List<Person> UpdatedPerson()
        {
            List<Person> result = new List<Person>();
            var filename = "SalesRecords.txt";
            if (File.Exists(filename))
            {
                foreach(var text in File.ReadLines(filename))
                {
                    var s = text.Split(',');
                    var person = new Person
                    {
                        PersonName = s[0],
                        Pen = Convert.ToDecimal(s[1]),
                        Pencil = Convert.ToDecimal(s[2]),
                        Eraser = Convert.ToDecimal(s[3]),
                        Ruler = Convert.ToDecimal(s[4]),
                        LiWhite = Convert.ToDecimal(s[5])
                    };
                    result.Add(person);
                }
            }
            return result;
        }
        static public List<Thing> UpdatedThing()
        {
            List<Thing> result = new List<Thing>();
            var filename = "Pricelist.txt";
            if (File.Exists(filename))
            {
                foreach (var text in File.ReadLines(filename))
                {
                    var s = text.Split(',');
                    NameList.Add(s[0]);
                    NameList.Add(s[2]);
                    NameList.Add(s[4]);
                    NameList.Add(s[6]);
                    NameList.Add(s[8]);
                    var t = new Thing
                    {
                        Pen = Convert.ToDecimal(s[1]),
                        Pencil = Convert.ToDecimal(s[3]),
                        Eraser = Convert.ToDecimal(s[5]),
                        Ruler = Convert.ToDecimal(s[7]),
                        LiWhite = Convert.ToDecimal(s[9])
                    };
                    result.Add(t);
                }
            }
            return result;
        }
        static public List<decimal> ThingTotalMoney(List<Person> ThingAmount,List<Thing> ThingMoney)
        {
            List<decimal> result = new List<decimal>();
            result.Add(CalculateMoney(ThingAmount.Sum(x => x.Pen), ThingMoney.Sum(x => x.Pen)));
            result.Add(CalculateMoney(ThingAmount.Sum(x => x.Pencil), ThingMoney.Sum(x => x.Pencil)));
            result.Add(CalculateMoney(ThingAmount.Sum(x => x.Eraser), ThingMoney.Sum(x => x.Eraser)));
            result.Add(CalculateMoney(ThingAmount.Sum(x => x.Ruler), ThingMoney.Sum(x => x.Ruler)));
            result.Add(CalculateMoney(ThingAmount.Sum(x => x.LiWhite), ThingMoney.Sum(x => x.LiWhite)));
            return result;
        }
        static public List<Thing> DecimalToThing(List<decimal> list)
        {
            List<Thing> ThingDeciaml = new List<Thing>();
            var t = new Thing
            {
                Pen = list[0],
                Pencil = list[1],
                Eraser = list[2],
                Ruler = list[3],
                LiWhite = list[4]
            };
            ThingDeciaml.Add(t);
            return ThingDeciaml;
        }
        static public List<string> ThingName()
        {
            return NameList;
        }
        static public void CalculatePersonTotalMoney(List<Person> personList,List<Thing> thingList)
        {
            foreach (var item in personList)
            {
                item.TotalMoney =
                    DataProcessing.CalculateMoney(item.Pen, thingList.Sum(x => x.Pen)) +
                    DataProcessing.CalculateMoney(item.Pen, thingList.Sum(x => x.Pencil)) +
                    DataProcessing.CalculateMoney(item.Eraser, thingList.Sum(x => x.Eraser)) +
                    DataProcessing.CalculateMoney(item.Ruler, thingList.Sum(x => x.Ruler)) +
                    DataProcessing.CalculateMoney(item.LiWhite, thingList.Sum(x => x.LiWhite));
            }
        }
        static public decimal CalculateMoney(decimal p, decimal t)
        {
            var money = p * t;
            return money;
        }
    }
}
