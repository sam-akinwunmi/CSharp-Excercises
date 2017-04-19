using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyZeroesTheFactorialOfAGiven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            double sumOfZeroes = new int();
            double divisor = 5;
            while ((divisor * 2) <= n)
            {
                sumOfZeroes += (n / divisor);
                divisor = Math.Pow(divisor, 2);
            }
            Console.WriteLine("Answer = " + sumOfZeroes);
        }
    }
}
