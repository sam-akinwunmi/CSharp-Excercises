using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of values you wish to sum: ");
            int nRepeats = new int();
            bool tryParseN = int.TryParse(Console.ReadLine(), out nRepeats);
            while (!tryParseN)
            {
                Console.Write("Please enter a valid number: ");
                tryParseN = int.TryParse(Console.ReadLine(), out nRepeats);
            }

            long sumOfValues = new long();
            long uniqueValue = new long();
            for (int i = 1; i <= nRepeats; i++)
            {
                Console.Write("Please enter your value {0}: ", i);
                bool tryParseVal = long.TryParse(Console.ReadLine(), out uniqueValue);
                while (!tryParseVal)
                {
                    Console.Write("Please enter a valid number: ");
                    tryParseVal = long.TryParse(Console.ReadLine(), out uniqueValue);
                }
                sumOfValues += uniqueValue;
            }
            Console.WriteLine("The sum of your values is {0}", sumOfValues);
        }
    }
}
