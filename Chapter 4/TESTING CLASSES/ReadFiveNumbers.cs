using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsFiveIntegerNumbersAndPrintsTheir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers as prompted. This program will work out the sum of the 5 numbers.");

            long userNumber1 = EnterNumberLoop(1);
            long userNumber2 = EnterNumberLoop(2);
            long userNumber3 = EnterNumberLoop(3);
            long userNumber4 = EnterNumberLoop(4);
            long userNumber5 = EnterNumberLoop(5);

            long sumOfFiveNumbers = userNumber1 + userNumber2 + userNumber3 + userNumber4 + userNumber5;

            Console.WriteLine("The sum of your numbers is {0}", sumOfFiveNumbers);
        }

        static long EnterNumberLoop(int i)
        {
            Console.Write("Please enter number {0}: ", i);
            string str = Console.ReadLine();
            long strValue = new long();
            bool tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                return strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    tryParse = long.TryParse(str, out strValue);
                }
                return strValue;
            }
        }
    }
}
