using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumbersArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Enter a number: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort<int>(numArray);
            Array.Reverse(numArray);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
