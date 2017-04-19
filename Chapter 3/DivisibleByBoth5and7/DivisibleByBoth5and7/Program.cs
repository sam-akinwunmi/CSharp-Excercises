using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByBoth5and7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            bool isNumberDivisible = (userNumber % 5 == 0 && userNumber % 7 == 0);
            Console.WriteLine(isNumberDivisible);
        }
    }
}
