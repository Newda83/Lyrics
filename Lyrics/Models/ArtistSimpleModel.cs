using Lyrics.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.Models
{
    public class ArtistSimpleModel
    {
        public string Name { get; set; }
        public double AverageLyrics { get; set; }
        public bool FoundArtist { get; set; }

        public ArtistSimpleModel(Artist artist)
        {
            if (artist != null)
            {
                Name = artist.Name;
                AverageLyrics = artist.GetAverageLyrics();
                FoundArtist = AverageLyrics != 0;
            }
            else
            {
                FoundArtist = false;
            }
        }
    }
}
