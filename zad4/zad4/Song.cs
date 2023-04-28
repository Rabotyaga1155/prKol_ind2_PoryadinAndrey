using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Song
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }

        public Song(string artistName, string songName)
        {
            ArtistName = artistName;
            SongName = songName;
        }
    }
}
