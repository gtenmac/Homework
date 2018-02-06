using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp3
{
    class DataProcess
    {
        static public List<string> list1 = new List<string>();
        static public List<string> list2 = new List<string>();
        static public Dictionary<string,Dictionary<string,decimal>> ReadText()
        {
            Dictionary<string, Dictionary<string, decimal>> dic = new Dictionary<string, Dictionary<string, decimal>>();
            string filename = "Ticket.txt";
            if (File.Exists(filename))
            {
                var s = File.ReadAllLines(filename);
                var line1 = s[0].Split(',');
                for(int i = 1,k=0; i < s.Length; i++,k++)
                {
                    var t = s[i].Split(',');
                    Dictionary<string, decimal> _dic = new Dictionary<string, decimal>();
                    for(int j = 0; j < t.Length; j++)
                    {
                        _dic.Add(line1[j], Convert.ToDecimal(t[j]));
                    }
                    dic.Add(line1[k], _dic);
                    list1.Add(line1[k]);
                    list2.Add(line1[k]);
                }
            }
            return dic;
        }
    }
    class Data
    {
        static public bool CheckBox1;
        static public bool CheckBox2;
        static public string ComboBox1;
        static public string ComboBox2;
        static public decimal Money;
    }
}
