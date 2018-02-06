using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Person
    {
        public string PersonName { get; set; }
        public int PenAmount { get; set; }
        public int PencilAmount { get; set; }
        public int EraserAmount { get; set; }
        public int RulerAmount { get; set; }
        public int LiwhiteAmount { get; set; }
        public decimal TotalMoney { get; set; }
        public List< Person> SalesRecords = new List<Person>();
        public Dictionary<string, int> DicSearch = new Dictionary<string, int>();
        
        public void CreateList()
        {
            string FileName = "SalesRecords.txt";
            if (File.Exists(FileName))
            {
                foreach (var s in File.ReadLines(FileName))
                {
                    var i = s.Split(',');
                    var person = new Person
                    {
                        PersonName = Convert.ToString(i[0]),
                        PencilAmount = Convert.ToInt32(i[1]),
                        PenAmount = Convert.ToInt32(i[2]),
                        EraserAmount = Convert.ToInt32(i[3]),
                        RulerAmount = Convert.ToInt32(i[4]),
                        LiwhiteAmount = Convert.ToInt32(i[5]),
                    };
                    person.DicSearch.Add("原子筆",person.PenAmount);
                    person.DicSearch.Add("鉛筆", person.PencilAmount);
                    person.DicSearch.Add("直尺", person.RulerAmount);
                    person.DicSearch.Add("立可白", person.LiwhiteAmount);
                    person.DicSearch.Add("橡皮擦", person.EraserAmount);
                    SalesRecords.Add(person);
                }
            }
        }
    }
}
