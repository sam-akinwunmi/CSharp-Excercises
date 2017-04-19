using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsAllNumbersInTheRange1._.N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int length = new int();
            bool parseLength = int.TryParse(Console.ReadLine(), out length);
            while (!parseLength)
            {
                Console.Write("Please enter a valid number");
                parseLength = int.TryParse(Console.ReadLine(), out length);
            }
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
