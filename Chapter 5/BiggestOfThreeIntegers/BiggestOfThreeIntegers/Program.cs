using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber = new int();
            Console.Write("a: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            biggestNumber = numberOne;
            Console.Write("b: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberTwo > biggestNumber)
            {
                biggestNumber = numberTwo;
            }
            Console.Write("c: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            if (numberThree > biggestNumber)
            {
                biggestNumber = numberThree;
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
