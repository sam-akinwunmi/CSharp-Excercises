using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequenceOfConsecutiveEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int bestStart = new int();
            int bestLength = new int();
            int length = 1;
            int start = new int();

            for (int i = 0; i < arrayLength - 1; i++)
            {

                if (i > 0)
                    if (array[i] != array[i - 1])
                    {
                        length = 1;
                        start = i;
                    }

                if (array[i] == array [i + 1])
                    length += 1;

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            Console.Write("The maximal sequence is ");

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
