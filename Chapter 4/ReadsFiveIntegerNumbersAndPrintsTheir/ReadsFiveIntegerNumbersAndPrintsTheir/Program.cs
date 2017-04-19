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
            long userNumber1 = new long();
            long userNumber2 = new long();
            long userNumber3 = new long();
            long userNumber4 = new long();
            long userNumber5 = new long();

            Console.Write("Please enter number 1: ");
            string str = Console.ReadLine();
            long strValue = new long();
            bool tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                userNumber1 = strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    strValue = new long();
                    tryParse = long.TryParse(str, out strValue);
                }
                userNumber1 = strValue;
            }


            Console.Write("Please enter number 2: ");
            str = Console.ReadLine();
            strValue = new long();
            tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                userNumber2 = strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    strValue = new long();
                    tryParse = long.TryParse(str, out strValue);
                }
                userNumber2 = strValue;
            }


            Console.Write("Please enter number 3: ");
            str = Console.ReadLine();
            strValue = new long();
            tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                userNumber3 = strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    strValue = new long();
                    tryParse = long.TryParse(str, out strValue);
                }
                userNumber3 = strValue;
            }


            Console.Write("Please enter number 4: ");
            str = Console.ReadLine();
            strValue = new long();
            tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                userNumber4 = strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    strValue = new long();
                    tryParse = long.TryParse(str, out strValue);
                }
                userNumber4 = strValue;
            }


            Console.Write("Please enter number 5: ");
            str = Console.ReadLine();
            strValue = new long();
            tryParse = long.TryParse(str, out strValue);
            if (tryParse)
            {
                userNumber5 = strValue;
            }
            else
            {
                while (!tryParse)
                {
                    Console.Write("Please enter a valid whole number: ");
                    str = Console.ReadLine();
                    strValue = new long();
                    tryParse = long.TryParse(str, out strValue);
                }
                userNumber5 = strValue;
            }

            long sumOfFiveNumbers = userNumber1 + userNumber2 + userNumber3 + userNumber4 + userNumber5;

            Console.WriteLine("The sum of your numbers is {0}", sumOfFiveNumbers);
        }
    }
}
