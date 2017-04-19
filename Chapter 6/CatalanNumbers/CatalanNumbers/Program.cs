using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            double nthNumber = double.Parse(Console.ReadLine());
            if (nthNumber == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine("Answer = {0}", ((factorial(2 * nthNumber)) / ((factorial(nthNumber + 1)) * factorial(nthNumber))));
            }
        }
        public static double factorial(double n)
        {
            double previousCalculation = 1;
            double newCalculation = new double();
            for (int i = 1; i <= n; i++)
            {
                newCalculation = i * previousCalculation;
                previousCalculation = newCalculation;
            }
            return newCalculation;
        }
    }
}
