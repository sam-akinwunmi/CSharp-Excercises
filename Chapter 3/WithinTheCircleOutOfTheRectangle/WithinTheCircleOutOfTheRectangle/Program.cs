using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithinTheCircleOutOfTheRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your x and y values to check whether the point lies within the circle and out of the rectangle\nx: ");
            double xVal = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double yVal = Convert.ToDouble(Console.ReadLine());
            int radius = 5;

            bool withinCircleTest = (Math.Pow(xVal,2) + Math.Pow(yVal, 2)) <= Math.Pow(radius, 2);

            bool outOfRectangle = xVal < -1 || yVal < 1;
            
            if (withinCircleTest && outOfRectangle)
            {
                Console.WriteLine("Congratulations, your point lies on or within the circle and out of the rectangle.");
            }
            else
            {
                Console.WriteLine("Your point does not lies out of the circle, or in the triangle. Please pick another point.");
            }
        }
    }
}
