using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsThreeNumbersInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            int sumOfNumbers = numberOne + numberTwo + numberThree;

            Console.WriteLine("The sum of your numbers is {0}.", sumOfNumbers);
        }
    }
}
