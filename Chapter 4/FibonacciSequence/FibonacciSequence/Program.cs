using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibLength = GetFibLength();

            if (fibLength == 0)
            {
                Console.WriteLine("Enter a number greater than zero!");
                fibLength = GetFibLength();
            }

            int fibArrayLength = fibLength + 1;

            double[] fibArray = new double[fibArrayLength];

            fibArray[0] = 0;
            fibArray[1] = 1;

            Console.Write(fibArray[0] + ", ");
            Console.Write(fibArray[1] + ", ");

            for (int i = 2; i <= fibLength; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                Console.Write(fibArray[i] + ", ");
            }
        }

        static int GetFibLength()
        {
            Console.WriteLine("Note: This sequence is zero based!");
            Console.Write("Enter a number: ");
            int nthFibNumber = new int();
            bool tryParse = int.TryParse(Console.ReadLine(), out nthFibNumber);
            while (!tryParse)
            {
                Console.Write("Enter a valid number: ");
                tryParse = int.TryParse(Console.ReadLine(), out nthFibNumber);
            }
            return nthFibNumber;
        }
    }
}
