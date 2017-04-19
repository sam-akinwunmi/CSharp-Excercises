using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter: ");
            int countNumbers = int.Parse(Console.ReadLine());
            int[] numberArray = new int[countNumbers];
            int smallestNumber = Int32.MaxValue;
            int largestNumber = Int32.MinValue;
            for (int i = 0; i < countNumbers; i++)
            {
                Console.Write("Enter number {0}: ", (i + 1));
                numberArray[i] = int.Parse(Console.ReadLine());
                if (numberArray[i] < smallestNumber)
                {
                    smallestNumber = numberArray[i];
                }
                if (numberArray[i] > largestNumber)
                {
                    largestNumber = numberArray[i];
                }
            }
            Console.WriteLine("Largest = {0}", largestNumber);

            Console.WriteLine("Smallest = {0}", smallestNumber);
        }
    }
}
