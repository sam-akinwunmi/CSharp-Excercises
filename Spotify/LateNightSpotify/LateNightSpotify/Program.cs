using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

namespace LateNightSpotify
{
    class Program
    {
        private static SpotifyWebAPI _spotify;

        public static void Main(String[] args)
        {
            Paging<SavedTrack> savedTracks = _spotify.GetSavedTracks();
            savedTracks.Items.ForEach(track => Console.WriteLine(track.Track.Name));
        }

        static ImplicitGrantAuth auth;

        static void Dry(string[] args)
        {
            //Create the auth object
            auth = new ImplicitGrantAuth()
            {
                //Your client Id
                ClientId = "40aea97c36ce42c4a7027d9b1eeed207",
                //Set this to localhost if you want to use the built-in HTTP Server
                RedirectUri = "http://localhost",
                //How many permissions we need?
                Scope = Scope.UserLibrarayRead,
            };
            //Start internal HTTP server
            auth.StartHttpServer();
            //When we get our response
            auth.OnResponseReceivedEvent += auth_OnResponseReceivedEvent;
            //Start
            auth.DoAuth();
        }

        static void auth_OnResponseReceivedEvent(Token token, string error)
        {
            //stop the http server
            auth.StopHttpServer();

            var spotify = new SpotifyWebAPI()
            {
                TokenType = token.TokenType,
                AccessToken = token.AccessToken
            };
            //We can now make calls with the token object
        }
    }
}
