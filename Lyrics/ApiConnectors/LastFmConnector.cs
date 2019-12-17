using IF.Lastfm.Core.Api;
using Lyrics.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.ApiConnectors
{
    public class LastFmConnector
    {
        readonly LastfmClient Client;
        private const string ApiKey = "745ba577a6bd84cf1dc5354d2368ca4d";
        private const string Secret = "9117c78507062e4309c4e192a2bc1ae4";
        readonly LyricsOvhConnector LyricsConnector;

        public LastFmConnector()
        {
            Client = new LastfmClient(ApiKey, Secret);
            LyricsConnector = new LyricsOvhConnector();
        }


        public async Task<Artist> GetArtistDetails(string name)
        {
            var artist = await GetArtistAndAlbums(name);
            if (artist == null)
            {
                return null;
            }

            foreach (var album in artist.Albums)
            {
                foreach (var track in album.Tracks)
                {
                    var lyrics = await LyricsConnector.GetLyrics(artist.Name, track.Name);
                    track.Lyrics = lyrics;
                }
            }
            return artist;
        }


        // call lastfm api to find the artist from the name, then gets a list of their albums, then tracks for each album
        private async Task<Artist> GetArtistAndAlbums(string name)
        {
            var artistResponse = await Client.Artist.SearchAsync(name);
            var result = artistResponse.Content.FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            var albumsResponse = await Client.Artist.GetTopAlbumsAsync(name);
            var albums = albumsResponse.Content.AsEnumerable();

            var artist = new Artist
            {
                Name = result.Name,
                Albums = new List<Album>()
            };

            foreach (var album in albums)
            {
                var albumInfo = await Client.Album.GetInfoAsync(name, album.Name);
                var tracks = albumInfo.Content.Tracks;
                var newAlbum = new Album
                {
                    Name = album.Name,
                    Tracks = new List<Track>()
                };
                foreach(var track in tracks)
                {
                    newAlbum.Tracks.Add(new Track { Name = track.Name });
                }
                artist.Albums.Add(newAlbum);

            }

            return artist;
        }

        
    }
}
