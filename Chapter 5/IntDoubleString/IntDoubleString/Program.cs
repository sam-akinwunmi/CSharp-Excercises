using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select from a (int), b (double) or c (string): ");
            char userSelection = Convert.ToChar(Console.ReadLine());
            switch (userSelection)
            {
                case 'a': Console.Write("Enter a number: ");
                    int userInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userInt + 1);
                    break;
                case 'b': Console.Write("Enter a number: ");
                    double userDouble = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userDouble + 1);
                    break;
                case 'c': Console.Write("Enter some text: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString + "*");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
