﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }
        }
    }
}
