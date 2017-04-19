using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a whole number: ");
            string userString = Console.ReadLine();
            int userNumber = new int();
            bool parseSuccess = Int32.TryParse(userString, out userNumber);
            if (parseSuccess)
            {
                Console.WriteLine("The square of your number is {0}.", userNumber * userNumber);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }
}
