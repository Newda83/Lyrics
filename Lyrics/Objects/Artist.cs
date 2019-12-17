using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.Objects
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }

        // method that counts the number of lyrics and tracks then calulates the mean
        public double GetAverageLyrics()
        {
            int totalTracks = 0;
            int totalLyrics = 0;
            foreach(var album in Albums)
            {
                foreach(var track in album.Tracks)
                {
                    totalTracks++;
                    totalLyrics += track.GetNumberOfLyrics();
                }
            }
            if (totalTracks == 0)
            {
                return 0.0;
            }
            return (double)totalLyrics / (double)totalTracks;
        }

        public string GetMostPopularLyric()
        {
            return GetOrderedLyricList().First().Lyric;
        }


        // works out number of occurences for each word, then order by the amount
        public List<LyricCounter> GetOrderedLyricList()
        {
            var listOfLyrics = new List<string>();
            foreach (var album in Albums)
            {
                foreach (var track in album.Tracks)
                {
                    listOfLyrics.AddRange(track.GetLyricsAsArray());
                }
            }

            var lyricCounter = new List<LyricCounter>();
            foreach (var lyric in listOfLyrics)
            {
                if (lyricCounter.Any(x => x.Lyric == lyric))
                {
                    var tempLyric = lyricCounter.Where(x => x.Lyric == lyric).Single();
                    tempLyric.Count++;
                }
                else
                {
                    lyricCounter.Add(new LyricCounter
                    {
                        Lyric = lyric,
                        Count = 1
                    });
                }
            }

            var sortedLyrics = lyricCounter.OrderByDescending(x => x.Count).ToList();
            return sortedLyrics;
        }
    }
}
