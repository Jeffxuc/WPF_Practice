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

namespace Pr13_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //因为选中的是ListBox，所以sender只能先转换成ListBox控件，
            ListBoxItem Selectitem = (sender as ListBox).SelectedItem as ListBoxItem;
            tb.Text = Selectitem.Content.ToString() + " have been selected.";
        }
    }
}
