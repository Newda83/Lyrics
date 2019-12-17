using Lyrics.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.ApiConnectors
{
    public class LyricsOvhConnector
    {
        readonly RestClient Client;
        private const string BaseUrl = "https://api.lyrics.ovh/v1/";
        public LyricsOvhConnector()
        {
            Client = new RestClient(BaseUrl);
        }

        // calls the lyrics api with restsharp, then returns full lyrics if found
        public string GetLyrics(string artist, string title)
        {
            try
            {
                title = title.Replace("/", "%2F");
                var request = new RestRequest($"{artist}/{title}");
                var response = Client.Execute<LyricsSearch>(request);
                return response.Data.Lyrics;
            }
            catch
            {
                return "";
            }
        }
    }
}
