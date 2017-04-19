using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            char one = 'a';
            int two = 97;
            Console.WriteLine(one < two);

            Console.WriteLine();
            Console.WriteLine("2.");
            int a = 6;
            int b = 5;
            if (a > b)
                Console.WriteLine("True");
                Console.WriteLine("Testing to see if this will write to console");

            Console.WriteLine();
            Console.WriteLine("3.");
            int number = 1;
            number *= -1;
            Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("4.");

            switch ("my name is sam")
            {
                case "my name is david":
                    Console.WriteLine("This shouldnt come up"); break;
                case "my name is sam":
                    Console.WriteLine("This should"); break;
                default:
                    Console.WriteLine("Number clearly above 6 or letter"); break;
            }

        }
    }
}
