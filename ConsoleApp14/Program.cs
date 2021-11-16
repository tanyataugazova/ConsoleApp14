using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double A = 10, B = 20, k, i;
            for (i = A; i <= B; i++)
            {

                k = Math.Pow(i, 2);
                Console.WriteLine($"{i} в квадрате ={k}");
            }
            Console.ReadKey();
        }
    }
}
