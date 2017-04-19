using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertsANumberInTheRange0_999ToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number in the range 0 - 999: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int numberLength = (int)(Math.Floor(Math.Log10(userNumber) + 1)); //Taken from http://stackoverflow.com/questions/4483886/how-can-i-get-a-count-of-the-total-number-of-digits-in-a-number
            int firstDigit = new int();
            int secondDigit = new int();
            int thirdDigit = new int();
            switch (userNumber)
            {
                case 0: Console.WriteLine("Zero"); break;
                default:
                    break;
            }
            switch (numberLength)
            {
                case 1: firstDigit = userNumber;
                    break;
                case 2: firstDigit = userNumber / 10;
                    secondDigit = userNumber % 10;
                    break;
                case 3: firstDigit = userNumber / 100;
                    secondDigit = userNumber % 100 / 10;
                    thirdDigit = userNumber % 10;
                    break;
                default:
                    break;
            }
            switch (numberLength)
            {
                case 1:
                    switch (firstDigit)
                    {
                        case 1: Console.WriteLine("One"); break;
                        case 2: Console.WriteLine("Two"); break;
                        case 3: Console.WriteLine("Three"); break;
                        case 4: Console.WriteLine("Four"); break;
                        case 5: Console.WriteLine("Five"); break;
                        case 6: Console.WriteLine("Six"); break;
                        case 7: Console.WriteLine("Seven"); break;
                        case 8: Console.WriteLine("Eight"); break;
                        case 9: Console.WriteLine("Nine"); break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (firstDigit)
                    {
                        case 1:
                            switch (secondDigit)
                            {
                                case 0: Console.WriteLine("Ten"); break;
                                case 1: Console.WriteLine("Eleven"); break;
                                case 2: Console.WriteLine("Twelve"); break;
                                case 3: Console.WriteLine("Thirteen"); break;
                                case 4: Console.WriteLine("Fourteen"); break;
                                case 5: Console.WriteLine("Ten"); break;
                                case 6: Console.WriteLine("Ten"); break;
                                case 7: Console.WriteLine("Ten"); break;
                                case 8: Console.WriteLine("Ten"); break;
                                case 9: Console.WriteLine("Ten"); break;
                                default:
                                    break;
                            }
                            break;
                        case 2: Console.Write("Twenty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("Thirty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write("Fourty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write("Fifty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write("Sixty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write("Seventy");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write("Eighty");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write("Ninety");
                            switch (secondDigit)
                            {
                                case 1: Console.WriteLine(" One"); break;
                                case 2: Console.WriteLine(" Two"); break;
                                case 3: Console.WriteLine(" Three"); break;
                                case 4: Console.WriteLine(" Four"); break;
                                case 5: Console.WriteLine(" Five"); break;
                                case 6: Console.WriteLine(" Six"); break;
                                case 7: Console.WriteLine(" Seven"); break;
                                case 8: Console.WriteLine(" Eight"); break;
                                case 9: Console.WriteLine(" Nine"); break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (firstDigit)
                    {
                        case 1: Console.Write("One Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2: Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            Console.Write("Two Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("Three Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write("Four Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write("Five Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write("Six Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write("Seven Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write("Eight Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write("Nine Hundred");
                            switch (secondDigit)
                            {
                                case 0:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(); break;
                                        case 1: Console.WriteLine(" and One"); break;
                                        case 2: Console.WriteLine(" and Two"); break;
                                        case 3: Console.WriteLine(" and Three"); break;
                                        case 4: Console.WriteLine(" and Four"); break;
                                        case 5: Console.WriteLine(" and Five"); break;
                                        case 6: Console.WriteLine(" and Six"); break;
                                        case 7: Console.WriteLine(" and Seven"); break;
                                        case 8: Console.WriteLine(" and Eight"); break;
                                        case 9: Console.WriteLine(" and Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (thirdDigit)
                                    {
                                        case 0: Console.WriteLine(" and Ten"); break;
                                        case 1: Console.WriteLine(" and Eleven"); break;
                                        case 2: Console.WriteLine(" and Twelve"); break;
                                        case 3: Console.WriteLine(" and Thirteen"); break;
                                        case 4: Console.WriteLine(" and Fourteen"); break;
                                        case 5: Console.WriteLine(" and Fifteen"); break;
                                        case 6: Console.WriteLine(" and Sixteen"); break;
                                        case 7: Console.WriteLine(" and Seventeen"); break;
                                        case 8: Console.WriteLine(" and Eighteen"); break;
                                        case 9: Console.WriteLine(" and Nineteen"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Write(" and Twenty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Write(" and Thirty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Write(" and Fourty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    Console.Write(" and Fifty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.Write(" and Sixty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    Console.Write(" and Seventy");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    Console.Write(" and Eighty");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 9:
                                    Console.Write(" and Ninety");
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine(" One"); break;
                                        case 2: Console.WriteLine(" Two"); break;
                                        case 3: Console.WriteLine(" Three"); break;
                                        case 4: Console.WriteLine(" Four"); break;
                                        case 5: Console.WriteLine(" Five"); break;
                                        case 6: Console.WriteLine(" Six"); break;
                                        case 7: Console.WriteLine(" Seven"); break;
                                        case 8: Console.WriteLine(" Eigth"); break;
                                        case 9: Console.WriteLine(" Nine"); break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
