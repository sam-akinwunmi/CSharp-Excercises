using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number between 1 and 100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = 2; i < userInput; i++)
            {
                if (userInput % i == 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("This is not a prime number");
            }
            else
            {
                Console.WriteLine("This is a prime number");
            }
        }
    }
}
