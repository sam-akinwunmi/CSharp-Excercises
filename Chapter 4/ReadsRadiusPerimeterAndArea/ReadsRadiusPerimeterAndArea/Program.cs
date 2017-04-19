using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsRadiusPerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of your circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The perimeter of the circle is {0} and the area of the circle is {1}", perimeter, area);
        }
    }
}
