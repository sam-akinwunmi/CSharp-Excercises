using System;

namespace RevereString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string you would like to reverse:");

            string userInput = Console.ReadLine();
            //string[] strings = new string[] { };

            //String.

            int inputLength = userInput.Length;

            for (int i = inputLength; i > 0; i--)
            {
                string subStr = userInput.Substring(i - 1, 1);
                Console.Write("{0}", subStr);
            }

            Console.ReadKey();
        }
    }
}
