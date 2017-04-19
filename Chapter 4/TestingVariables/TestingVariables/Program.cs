using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            number1 = Math.Max(number1, number2);
            Console.Write("3: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            number1 = Math.Max(number1, number2);
            Console.Write("4: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            number1 = Math.Max(number1, number2);
            Console.Write("5: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            number1 = Math.Max(number1, number2);

            Console.WriteLine("The greatest number you entered is {0}", number1);
        }
    }
}
