using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3RealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo && numberTwo > numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
            }
            else if (numberOne > numberThree && numberThree > numberTwo)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
            }
            else if (numberTwo > numberOne && numberOne > numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
            }
            else if (numberTwo > numberThree && numberThree > numberOne)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
            }
            else if (numberThree > numberOne && numberOne > numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            else if (numberThree > numberTwo && numberTwo > numberOne)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
            }
        }
    }
}
