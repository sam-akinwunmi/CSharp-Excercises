using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int finalNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= finalNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
