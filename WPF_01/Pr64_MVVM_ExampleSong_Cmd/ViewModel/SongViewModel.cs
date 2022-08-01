using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Pr64_MVVM_ExampleSong_Cmd.Model;
using System.Windows.Input;

namespace Pr64_MVVM_ExampleSong_Cmd.ViewModel
{
    class SongViewModel : INotifyPropertyChanged
    {

        int count = 0;
        Song song_model;
        public Song song_Model
        {
            get { return song_model; }
            set { song_model = value; }
        }

        public string ArtistName
        {
            get { return song_Model.ArtistName; }
            set
            {
                if(value != song_Model.ArtistName)
                {
                    song_Model.ArtistName = value;
                    OnPropertyChanged();
                }
            }
        }


        public SongViewModel()
        {
            song_model = new Song() { ArtistName = "Tony", SongTitle = "One" };
        }


        #region Implement of the INotifyPropertyChanged interface.

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion


        #region Command 
        void UpdateArtistNameExecute()
        {
            ++count;
            ArtistName = string.Format("Jeff-{0}", count);
        }

        bool CanUpdateArtistNameExecute()
        {
            return true;
        }

        public ICommand UpdateArtistName
        {
            get
            {
                return new RelayCommand(UpdateArtistNameExecute, CanUpdateArtistNameExecute);
            }
        }

        #endregion

    }
}
