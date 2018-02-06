using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迴圈倒置_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入 = ");
            int i = int.Parse(Console.ReadLine());
            int x, y, j = i;
            for (x = 1; x <= j; x++,i--)
            {
                for (y = i; y <= j; y++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
