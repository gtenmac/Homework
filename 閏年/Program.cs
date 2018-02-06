using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 閏年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入 = ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year < 1911 ? year + 1911 : year))
            {
                Console.WriteLine("{0} is Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not Leap Year",year);
            }
        }
    }
}
