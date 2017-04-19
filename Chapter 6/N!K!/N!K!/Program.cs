using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_K_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int denominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Answer = {0}", (factorial(numerator) / factorial(denominator)));
        }
        public static int factorial(int n)
        {
            int previousCalculation = 1;
            int newCalculation = new int();
            for (int i = 1; i <= n; i++)
            {
                newCalculation = i * previousCalculation;
                previousCalculation = newCalculation;
            }
            return newCalculation;
        }
    }
}
