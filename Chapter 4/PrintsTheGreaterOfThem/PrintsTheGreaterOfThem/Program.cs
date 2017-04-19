using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsTheGreaterOfThem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(userInput1, userInput2));
        }
    }
}
