using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyrics.Objects
{
    public class Album
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
