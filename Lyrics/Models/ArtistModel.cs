using Lyrics.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.Models
{
    public class ArtistModel
    {
        public string Name { get; set; }
        public double AverageLyrics { get; set; }
        public List<LyricCounter> OrderedListOfLyrics { get; set; }
        public bool FoundArtist { get; set; }

        public ArtistModel(Artist artist)
        {
            if (artist != null)
            {
                FoundArtist = true;
                Name = artist.Name;
                OrderedListOfLyrics = artist.GetOrderedLyricList();
                if (OrderedListOfLyrics.Count == 0)
                {
                    FoundArtist = false;
                }
                AverageLyrics = artist.GetAverageLyrics();
            }
            else
            {
                FoundArtist = false;
            }
        }
    }
}
