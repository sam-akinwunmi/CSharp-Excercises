using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Console.WriteLine("{0} Fizz", i);
                else
                    if (i % 5 == 0 && i % 3 != 0)
                        Console.WriteLine("{0} Buzz", i);
                else
                    if (i % 5 == 0 && i % 3 == 0)
                        Console.WriteLine("{0} Fizz Buzz", i);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
