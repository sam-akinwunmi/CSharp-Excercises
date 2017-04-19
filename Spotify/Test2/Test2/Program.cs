using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyWebAPI;


namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = await SpotifyWebAPI.Album.GetAlbum("0Fk4lWAADmFMmuW6jp6xyE");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
