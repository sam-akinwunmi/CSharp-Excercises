using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsThreeNumbersInThreeVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            int varOne = 12345;
            double varTwo = 09.8765;
            double varThree = 8974.328;

            Console.WriteLine("{0, -10:x} {1, -10:.##} {2, -10:.##}", varOne, varTwo, varThree);
        }
    }
}
