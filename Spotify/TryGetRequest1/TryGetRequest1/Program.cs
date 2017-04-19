using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace TryGetRequest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetRequest("https://api.spotify.com/v1/users/sammygfx");
            GetRequest("https://api.spotify.com/v1/albums/0Fk4lWAADmFMmuW6jp6xyE");
            Console.ReadKey();
        }

        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        Console.WriteLine(myContent);
                    }
                }
            }
        }
    }
}
