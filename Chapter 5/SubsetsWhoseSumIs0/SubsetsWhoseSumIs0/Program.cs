using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetsWhoseSumIs0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumberArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                userNumberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (userNumberArray[0] + userNumberArray[1] == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                if (userNumberArray[0] + userNumberArray[1] + userNumberArray[2] == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    if (userNumberArray[0] + userNumberArray[1] + userNumberArray[2] + userNumberArray[3] == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        if (userNumberArray[0] + userNumberArray[1] + userNumberArray[2] + userNumberArray[3] + userNumberArray[4] == 0)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            if (userNumberArray[1] + userNumberArray[2] == 0)
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                if (userNumberArray[1] + userNumberArray[2] + userNumberArray[3] == 0)
                                {
                                    Console.WriteLine("True");
                                }
                                else
                                {
                                    if (userNumberArray[1] + userNumberArray[2] + userNumberArray[3] + userNumberArray[4] == 0)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else
                                    {
                                        if (userNumberArray[2] + userNumberArray[3] == 0)
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else
                                        {
                                            if (userNumberArray[2] + userNumberArray[3] + userNumberArray[4] == 0)
                                            {
                                                Console.WriteLine("True");
                                            }
                                            else
                                            {
                                                if (userNumberArray[3] + userNumberArray[4] == 0)
                                                {
                                                    Console.WriteLine("True");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("False");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
