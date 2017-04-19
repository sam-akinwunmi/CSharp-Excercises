using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");

            int ageOfUser = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In 10 years you will be {0} years old!", ageOfUser + 10);
        }
    }
}
