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
            //1
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);

            //2
            Console.Write("Enter n: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //3

        }
    }
}
