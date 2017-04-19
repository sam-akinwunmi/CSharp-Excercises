using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAndTheAreaOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program will caclculate the area and perimeter of a rectangle. Please enter the correct values for side and height.\nSide: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = side * height;
            double permimeter = ((side * 2) + (height + 2));

            Console.WriteLine("The area of your rectangle is " + area + " and the perimeter of your rectangle is " + permimeter);
        }
    }
}
