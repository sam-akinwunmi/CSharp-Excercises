using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOfAManOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your earth weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double moonWeight = weight * 0.17;
            Console.WriteLine("Your moon weight would be {0}kg", moonWeight);
        }
    }
}
