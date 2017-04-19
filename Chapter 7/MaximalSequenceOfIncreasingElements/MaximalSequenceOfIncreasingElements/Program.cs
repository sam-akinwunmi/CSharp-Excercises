using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequenceOfIncreasingElements
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
                Console.Write("{0} = ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int smallestNumber = int.MaxValue;
            int smallIndex = 0;
            List<int> MaximalSequence = new List<int>();

            for (int i = 0; i < arrayLength; i++)
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                    smallIndex = i;
                }

            int placeholder = smallIndex;

            MaximalSequence.Add(smallestNumber);

            int placeholderTwo = new int();

            while (smallIndex < arrayLength)
            {
                for (int i = smallIndex + 1; i < arrayLength; i++)
                {
                    if (i == placeholder + 1 && smallestNumber != int.MaxValue)
                        smallestNumber = int.MaxValue;

                    if (array[i] < smallestNumber && array[i] > placeholderTwo)
                    {
                        smallestNumber = array[i];
                        smallIndex = i;
                    }
                }

                placeholder = smallIndex;

                MaximalSequence.Add(smallestNumber);

                placeholderTwo = smallestNumber;

                if (arrayLength % 2 == 0)
                    if (placeholder + 1 == arrayLength - 1)
                        break;

                if (placeholder + 1 == arrayLength)
                    break;
            }

            MaximalSequence.ForEach(Console.WriteLine);
        }
    }
}