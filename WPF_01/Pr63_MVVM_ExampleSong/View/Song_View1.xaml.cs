using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pr63_MVVM_ExampleSong.ViewModel;

namespace Pr63_MVVM_ExampleSong.View
{
    /*
     * MVVM Example 01: 
     * 1. Use Click Event rather than Command.
     * 2. Implement the INotifyPropertyChanged in ViewMode.
     * 3. We will improve it in Example 02...
     */

    /// <summary>
    /// Interaction logic for Song_View1.xaml
    /// </summary>
    public partial class Song_View1 : UserControl
    {
        Song_ViewModel _viewMode = new Song_ViewModel();
        int count = 0;
        public Song_View1()
        {
            this.DataContext = _viewMode;

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            _viewMode.ArtistName = string.Format("Tom-{0}", count);
        }
    }
}
