using System;
using System.Linq;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Oplab_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a word to search for tweets:");
            string search = Console.ReadLine();
            Console.WriteLine();
            Auth.SetUserCredentials("5BZmdJoR1y6XvTv9yUZ65t0qV", "TGZoRvV82wWFO6Sf4Hv40dQTavg3nnQLuHKMxA9QZmRCtr1HVX",
                                                "81419467-QmwU8wIkVUtyoFptDG0f0j6YA1zVjtL2Zt0Albn08", "tBCe7qliVUuVFzrnvTMPnNGtKWdsaSyXPpnpteCUYYgZK");
            //var user = User.GetAuthenticatedUser();

            //Tweet.PublishTweet("I am learning webAPI with C#");

            var searchParameter = new SearchTweetsParameters(search)
            {
                SearchType = SearchResultType.Recent,
                MaximumNumberOfResults = 10
            };

            var tweets = Search.SearchTweets(searchParameter).ToArray();

            foreach (var list in tweets)
            {
                Console.WriteLine(list.Text);
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
