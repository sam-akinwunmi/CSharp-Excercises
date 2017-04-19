using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.MaxValue;
            ushort years = ushort.MaxValue;
            uint days = uint.MaxValue;
            ulong hours = ulong.MaxValue;

            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);

            float floatNumber = 3.12345678901234567890f;
            double doubleNumber = 3.12345678901234567890;
            decimal decimalNumber = 3.12345678901234567890m;

            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);

            int a = 1;
            int b = 2;

            bool aGreaterThanB = (a > b);
            bool eq1 = (a == 1);

            if (aGreaterThanB)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }

            Console.WriteLine("A is greater than B = {0}", aGreaterThanB);

            object object1 = 3.12345678901234567890m;
            Console.WriteLine(object1)  ;

            Console.WriteLine("my name is\nsam\tand i am twenty four years old");

            Console.WriteLine("testing");

            float excercise3Number1 = 0.000001f;
            double excercise3Number2 = 0.000001;

            Console.WriteLine(excercise3Number1);
            Console.WriteLine(excercise3Number2);
        }
    }
}
