using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsInformationAboutTheCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company Address: ");
            string address = Console.ReadLine();
            Console.Write("Company Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Company Fax Number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Company Website: ");
            string website = Console.ReadLine();
            Console.Write("Company Manager: ");
            string manager = Console.ReadLine();

            Console.WriteLine("The name of the company is {0}, and they can be contacted at {1}. " +
                "Their phone number is {2} and in case you are stuck in the last millenium, the faxs number is {3}. " +
                "The website is {4}, and the manager's name" +
                "is {5}", companyName, address, phoneNumber, faxNumber, website, manager);
        }
    }
}
