using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCQuadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double root = new int();
            double root2 = new int();
            Console.Write("a: ");
            double coeffA = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            double coeffB = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            double coeffC = Convert.ToInt32(Console.ReadLine());

            double discriminant = ((coeffB * coeffB) - (4 * coeffA * coeffC));

            if (discriminant == 0)
            {
                root = ((-1 * coeffB) / (2 * coeffA));
                Console.WriteLine("root: {0}", root);
            }
            else if (discriminant > 0)
            {
                root = ((-1 * coeffB) + Math.Sqrt((coeffB * coeffB) - (4 * coeffA * coeffC))) / (2 * coeffA);
                root2 = ((-1 * coeffB) - Math.Sqrt((coeffB * coeffB) - (4 * coeffA * coeffC))) / (2 * coeffA);
                Console.WriteLine("root1: {0}", root);
                Console.WriteLine("root2: {0}", root2);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("no real roots.");
            }
        }
    }
}
