using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequenceOfIncreasingElements2
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise to arrays. one for user input, and the other for the maximal sequence lengths
            Console.Write("n: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("{0}: ", i + 1);
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            int[] arrayTwo = new int[arrayLength];
            arrayTwo[0] = 1;

            //calculate the length of the maximal elements up to each point in the array
            for (int outer = 1; outer < arrayLength; outer++)
                for (int inner = 0; inner < outer; inner++)
                    if (arrayOne[inner] < arrayOne[outer] && arrayTwo[outer] < arrayTwo[inner] + 1)
                        arrayTwo[outer] = 1 + arrayTwo[inner];

            //find the length of the largest maximal input
            int highestNumber = int.MinValue;
            int position = new int();
            for (int i = 0; i < arrayLength; i++)
                if (arrayTwo[i] > highestNumber)
                {
                    highestNumber = arrayTwo[i];
                    position = i;
                }

            int[] result = new int[highestNumber + 1];

            for (int index = position; index >= 0; index--)
                if (arrayTwo[index] == highestNumber)
                {
                    result[highestNumber] = arrayOne[index];
                    highestNumber--;
                }

            foreach (var value in result)
                Console.Write(value + "  ");
        }
    }
}