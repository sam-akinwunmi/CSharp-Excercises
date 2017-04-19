using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrecisionOf0._001
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alternator = false;
            decimal numerator = (decimal)1;
            decimal denominator = (decimal)2;

            decimal newResult = (decimal)1;
            decimal oldResult = new decimal();

            do
            {
                oldResult = newResult;

                decimal addon = numerator / denominator;

                if (alternator == true)
                    addon *= -1;

                newResult = oldResult + addon;

                alternator = !alternator;

                denominator++;

            } while (Math.Abs(newResult - oldResult) > (decimal)0.001);

            //Console.WriteLine("Difference is less than 0.001.");

            if (decimal.Round(newResult, 3, MidpointRounding.AwayFromZero) == (decimal)1.307)
                Console.WriteLine("Sick1Mate.");
            else
                Console.WriteLine("Drhey.");
        }
    }
}