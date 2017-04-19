using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor_GCD_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("2: ");
            double numberTwo = double.Parse(Console.ReadLine());

            double multiplier = Math.Abs(numberOne * numberTwo);

            double GCD = new double();

            if (numberOne == 0)
                GCD = numberTwo;
            if (numberTwo == 0)
                GCD = numberOne;

            while (numberTwo != 0)
            {
                double greaterNumber = new double();
                double smallerNumber = new double();

                if (numberOne > numberTwo)
                {
                    greaterNumber = numberOne;
                    smallerNumber = numberTwo;
                }
                else
                {
                    greaterNumber = numberTwo;
                    smallerNumber = numberOne;
                }

                double remainder = new double();

                remainder = greaterNumber % smallerNumber;
                numberOne = smallerNumber;
                numberTwo = remainder;
            }

            if (numberOne == 0)
                GCD = numberTwo;
            else
                GCD = numberOne;

            Console.WriteLine("GCD: {0}", GCD);

            double LCM = multiplier / GCD;

            Console.WriteLine("LCM: {0}", LCM);
        }
    }
}
