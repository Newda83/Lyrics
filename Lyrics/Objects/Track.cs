using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.Objects
{
    public class Track
    {
        public string Name { get; set; }
        public string Lyrics { get; set; }

        public int GetNumberOfLyrics()
        {
            if (Lyrics == null)
            {
                return 0;
            }
            return GetLyricsAsArray().Length;
        }

        // splits the full string of lyrics into an array of all words
        public string[] GetLyricsAsArray()
        {
            if (Lyrics == null)
            {
                return new string[0];
            }
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            return Lyrics.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
