using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int oldA = a;

            a = b;
            b = oldA;

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
