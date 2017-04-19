using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "world!";

            object helloWorld = hello + " " + world;

            string helloWorldString = (string)helloWorld;

            Console.WriteLine(helloWorldString);
        }
    }
}
