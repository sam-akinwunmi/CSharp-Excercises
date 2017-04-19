using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            int negativeNumbersCount = new int();

            if (numberOne < 0)
            {
                negativeNumbersCount++;
            }
            if (numberTwo < 0)
            {
                negativeNumbersCount++;
            }
            if (numberThree < 0)
            {
                negativeNumbersCount++;
            }

            if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (negativeNumbersCount % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
