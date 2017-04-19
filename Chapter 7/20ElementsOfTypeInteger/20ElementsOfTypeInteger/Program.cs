using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ElementsOfTypeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = (i + 1) * 5;
                Console.Write(array[i] + " ");
            }
        }
    }
}
