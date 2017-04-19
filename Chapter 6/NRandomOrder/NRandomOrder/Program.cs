using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRandomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] oneToEnd = new int[n];
            for (int i = 0; i < n; i++)
            {
                oneToEnd[i] = i + 1;
            }

            Random RandomChoice = new Random();
            int randomNumber1 = new int();
            int randomNumber2 = new int();

            for (int i = 0; i < n; i++)
            {
                randomNumber1 = RandomChoice.Next(0, n);
                int swap1 = oneToEnd[randomNumber1];
                randomNumber2 = RandomChoice.Next(0, n);
                int swap2 = oneToEnd[randomNumber2];

                oneToEnd[randomNumber1] = swap2;
                oneToEnd[randomNumber2] = swap1;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(oneToEnd[i]);
            }
        }
    }
}
