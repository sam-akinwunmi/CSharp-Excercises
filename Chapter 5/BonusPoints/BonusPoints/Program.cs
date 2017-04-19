using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 9: ");
            int score = Convert.ToInt32(Console.ReadLine());
            switch (score)
            {
                case 1: score *= 10;
                    Console.WriteLine(score); break;
                case 2: score *= 10;
                    Console.WriteLine(score); break;
                case 3: score *= 10;
                    Console.WriteLine(score); break;
                case 4: score *= 100;
                    Console.WriteLine(score); break;
                case 5: score *= 100;
                    Console.WriteLine(score); break;
                case 6: score *= 100;
                    Console.WriteLine(score); break;
                case 7: score *= 1000;
                    Console.WriteLine(score); break;
                case 8: score *= 1000;
                    Console.WriteLine(score); break;
                case 9: score *= 1000;
                    Console.WriteLine(score); break;
                default:
                    Console.WriteLine("Error Message!");
                    break;
            }
        }
    }
}
