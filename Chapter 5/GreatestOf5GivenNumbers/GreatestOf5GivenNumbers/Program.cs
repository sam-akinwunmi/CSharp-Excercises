using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOf5GivenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter: ");
            int arraySize = new int();
            bool tryParse = Int32.TryParse(Console.ReadLine(), out arraySize);
            while (!tryParse)
            {
                Console.Write("Please try again: ");
                tryParse = Int32.TryParse(Console.ReadLine(), out arraySize);
            }
            int[] numberArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0}: ", i + 1);
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int greatestNumber = numberArray[0];
            for (int i = 1; i < arraySize; i++)
            {
                if (numberArray[i] > greatestNumber)
                {
                    greatestNumber = numberArray[i];
                }
            }
            Console.WriteLine(greatestNumber);
        }
    }
}
