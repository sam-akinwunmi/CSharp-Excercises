using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsTwoArraysChecksWhetherTheyAre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            Console.WriteLine("Enter Your First Array Values");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                int arrayValue = int.Parse(Console.ReadLine());
                array[i] = arrayValue;
            }

            int[] arrayTwo = new int[arrayLength];

            Console.WriteLine("Enter Your Second Array Values");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                int arrayValue = int.Parse(Console.ReadLine());
                arrayTwo[i] = arrayValue;
            }

            bool equal = true;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] != arrayTwo[i])
                {
                    equal = false;
                    break;
                }
            }

            if (equal == false)
                Console.WriteLine("not equal");
            else
                Console.WriteLine("equal");
        }
    }
}
