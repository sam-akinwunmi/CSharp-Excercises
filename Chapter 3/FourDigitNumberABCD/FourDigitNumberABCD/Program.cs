using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumberABCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your four digit number: ");
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());
            int d = (fourDigitNumber % 10);
            int c = ((fourDigitNumber / 10) % 10);
            int b = ((fourDigitNumber / 100) % 10);
            int a = ((fourDigitNumber / 1000) % 10);
            int sumOfDigits = (a + b + c + d);
            Console.WriteLine(sumOfDigits);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
