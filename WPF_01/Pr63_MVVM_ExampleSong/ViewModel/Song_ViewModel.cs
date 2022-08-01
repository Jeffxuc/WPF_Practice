using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pr63_MVVM_ExampleSong.Model;

namespace Pr63_MVVM_ExampleSong.ViewModel
{
    class Song_ViewModel : INotifyPropertyChanged
    {
        private Song_Model song_model;
        public Song_Model Song_Model
        {
            get { return song_model; }
            set
            {
                if(value!=song_model)
                {
                    song_model = value;
                }
            }
        }

        public Song_ViewModel()
        {
            song_model = new Song_Model() { ArtistName = "InitialName", SongTitle = "Strong and study" };
        }

        // Exposing a property: ArtistName in ViewModel.
        public string ArtistName
        {
            get { return Song_Model.ArtistName; }
            set
            {
                if(Song_Model.ArtistName != value)
                {
                    Song_Model.ArtistName = value;
                    OnPropertyChanged();
                }
            }
        }


        #region Implement the "INotifyPropertyChanged" interface in ViewModel

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
