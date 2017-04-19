using System;

namespace SumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount you would like to test.");

            int amountRequested = int.Parse(Console.ReadLine());

            int iterationNumber = ReturnCountNumber(amountRequested);

            int[] integerArray = ReturnNumbers(amountRequested);

            Console.WriteLine("Testing...");
            Console.WriteLine(ProcessNumbers(integerArray, iterationNumber));

            Console.ReadKey();
        }

        private static bool ProcessNumbers(int[] array, int iterationNumber)
        {
            int startIndex = 0;
            int secondaryIndex = 1;

            for (int i = startIndex; i < iterationNumber; i++)
            {
                int total = 0;

                if (startIndex == array.Length)
                    return false;

                for (int k = startIndex; k <= secondaryIndex; k++)
                {
                    total += array[k];

                    if (total == 0)
                    {
                        return true;
                    }
                }
                if (secondaryIndex == array.Length-1)
                {
                    startIndex++;
                    secondaryIndex = startIndex + 1;
                }
                else
                    secondaryIndex++;
            }

            return false;
        }

        private static int[] ReturnNumbers(int amount)
        {
            int[] integerArray = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Please enter a number: ");

                string stringNumber = Console.ReadLine();

                if (stringNumber != null && stringNumber != String.Empty)
                {
                    int myNumberValidated = 0;
                    bool result = int.TryParse(stringNumber, out myNumberValidated);

                    if (!result)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        i--;
                    }
                    else
                        integerArray[i] = myNumberValidated;
                }
                else
                {
                    Console.WriteLine("Please enter a valid string.");
                    i--;
                }
            }


            return integerArray;
        }

        private static int ReturnCountNumber(int amountRequested)
        {
            int newAmount = amountRequested;

            int newCount = 0;
            int newTotal = 0;

            for (int i = 0; i < newAmount - 1; i++)
            {
                newCount++;
                newTotal += newCount;
            }

            return newTotal;
        }
    }
}
