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

namespace Pr27_GraphicalShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn02 = new Button();
            btn02.Foreground = Brushes.Red;
            btn02.Background = Brushes.DarkViolet;  
            btn02.Content = "This is the Btn02";
            btn02.Margin = new Thickness(30);
            st.Children.Add(btn02);

            

        }
    }
}
