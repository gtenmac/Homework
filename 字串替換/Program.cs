using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串替換
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = Createdic();
            Console.Write("輸入 = ");
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(dic[int.Parse(Convert.ToString(s[i]))]);
            }
            Console.WriteLine();
        }
        static Dictionary<int, string> Createdic()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "零");
            dic.Add(1, "壹");
            dic.Add(2, "貳");
            dic.Add(3, "參");
            dic.Add(4, "肆");
            dic.Add(5, "伍");
            dic.Add(6, "陸");
            dic.Add(7, "柒");
            dic.Add(8, "捌");
            dic.Add(9, "玖");
            return dic;
        }
    }
}
