using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUser("sammygfx");
            Console.ReadKey();
        }

        async static void GetUser(string login)
        {
            var user = await SpotifyWebAPI.User.GetUser(login);
            Console.WriteLine(user);
        }
    }
}
