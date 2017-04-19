using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemainderOfTheirDivisionBy5is0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number 1: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number 2: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = numberOne; i <= numberTwo; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("In the range {0} and {1}, there are {2} numbers divisible by 5", numberOne, numberTwo, counter);
        }
    }
}
