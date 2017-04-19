using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExchanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            Console.Write("a: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int tempOne = numberOne;
            int tempTwo = numberTwo;

            if (numberOne > numberTwo)
            {
                numberOne = tempTwo;
                numberTwo = tempOne;
            }

            Console.WriteLine("a is going to be {0}", numberOne);
            Console.WriteLine("b is going to be {0}", numberTwo);
        }
    }
}
