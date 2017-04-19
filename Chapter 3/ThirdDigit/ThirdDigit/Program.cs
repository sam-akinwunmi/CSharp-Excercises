using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int divideBy100 = userInput / 100;
            int remainderFromDivideBy10 = divideBy100 % 10;
            if (remainderFromDivideBy10 == 7)
            {
                Console.WriteLine("Congratulations! The 3rd digit in your number is 7.");
            }
            else
            {
                Console.WriteLine("Unfortunately your number is not 7. Please try again later.");
            }
        }
    }
}
