using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶數判斷_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("輸入 = ");
            foreach(var s in Console.ReadLine().Split(','))
            {
                list.Add(int.Parse(s));
            }
            Console.WriteLine();
            foreach(var s in list.Where(x => x % 2 == 0))
            {
                Console.Write(s+",");
            }
            Console.WriteLine();
            foreach(var s in list.Where(x => x % 2 != 0))
            {
                Console.Write(s+",");
            }
        }
    }
}
