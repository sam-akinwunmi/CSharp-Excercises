using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKKConsecutiveElementsMaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int lengthArrayOne = int.Parse(Console.ReadLine());

            Console.Write("k (must be < than n): ");
            int consecutive = int.Parse(Console.ReadLine());

            int[] ArrayOne = new int[lengthArrayOne];

            for (int i = 0; i < lengthArrayOne; i++)
            {
                Console.Write("{0}: ", i + 1);
                ArrayOne[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
