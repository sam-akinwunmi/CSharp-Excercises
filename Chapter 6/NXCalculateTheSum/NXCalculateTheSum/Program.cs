using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXCalculateTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());

            double oldSum = 1;

            for (int i = 1; i <= n; i++)
            {
                double newSum = factorial(i) / Math.Pow(x, i);
                oldSum += newSum;
            }
            Console.WriteLine(oldSum);
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
