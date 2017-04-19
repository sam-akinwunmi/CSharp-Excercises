using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfATrapeziod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program will work out the area of a trapeziod. Please enter the values for a, b & h.\na: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("h: ");
            double sideH = Convert.ToDouble(Console.ReadLine());

            double areaOfTrapezoid = (((sideA + sideB) / 2) * sideH);

            Console.Write("The area of your Trapezoid is " + areaOfTrapezoid + ". ");
        }
    }
}
