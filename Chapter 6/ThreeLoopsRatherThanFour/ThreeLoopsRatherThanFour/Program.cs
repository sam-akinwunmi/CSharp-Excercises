using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLoopsRatherThanFour
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int cd = 0; cd <= 99; cd++)
                    {
                        int c1 = cd / 10;
                        int d1 = cd % 10;
                        if ((a + b) == (c1 + d1))
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} ", a, b, c1, d1);
                        }
                    }
                }
            }
        }
    }
}
