using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleBy3And7Sumultaneously
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int finalNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= finalNumber; i++)
            {
                if (!(i % (3 * 7) == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
