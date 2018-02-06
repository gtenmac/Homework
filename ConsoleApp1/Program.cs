using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number = ");
            int i = int.Parse(Console.ReadLine());
            switch (i%2)
            {
                case 0:
                    Console.WriteLine("{0}為偶數",i);
                    break;
                default:
                    Console.WriteLine("{0}為奇數",i);
                    break;
            }
        }
    }
}
