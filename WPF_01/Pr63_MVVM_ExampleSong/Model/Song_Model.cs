using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pr63_MVVM_ExampleSong.Model
{
    class Song_Model
    {
        string artistName;
        string songTitle;

        public string ArtistName
        {
            get { return artistName; }
            set { artistName = value; }
        }

        public string SongTitle
        {
            get { return songTitle; }
            set { songTitle = value; }
        }

    }
}
