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
namespace Pr02_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string str = "";
        public MainWindow()
        {
            InitializeComponent();
            LinearGradientBrush Lbrush = new LinearGradientBrush(Colors.Red, Colors.Blue, new Point(0, 0), new Point(1, 1));
            Background = Lbrush;

            BorderBrush = Brushes.DeepSkyBlue;
            BorderThickness = new Thickness(10, 10, 10, 10);

            Title = str;

            Content = null;
            FontFamily = new FontFamily("Times New Roman");
            FontSize = 30;


            
            
            
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);
            //string str = Content as string;


            if(e.Text=="\b")
            {
                if(str.Length>0)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }
            else
            {
                str += e.Text;
            }

            Content = str;
        }
    }
}
