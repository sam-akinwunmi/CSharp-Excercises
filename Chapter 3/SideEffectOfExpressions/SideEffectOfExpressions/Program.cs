using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideEffectOfExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = ++a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
