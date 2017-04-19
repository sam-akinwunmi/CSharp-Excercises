using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int finalCountInSequence = int.Parse(Console.ReadLine());
            int oldNumberOne = 0;
            int oldNumberTwo = 1;
            Console.Write("{0}, {1},", oldNumberOne, oldNumberTwo);
            for (int i = 2; i < finalCountInSequence; i++)
            {
                int newNumber = oldNumberOne + oldNumberTwo;
                Console.Write(" {0},", newNumber);
                oldNumberOne = oldNumberTwo;
                oldNumberTwo = newNumber;
            }
        }
    }
}
