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
using System.Windows.Shapes;

namespace Pr19_XMAL.SubItem
{
    /// <summary>
    /// Interaction logic for CompileXamlWindow.xaml
    /// </summary>
    public partial class CompileXamlWindow : Window
    {
        public CompileXamlWindow()
        {
            InitializeComponent(); //该函数会加载XAML文件来设置对应的属性和设置  
        }

        private void ButtonOnClicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("The button message " + btn.Content + " have been clicked");
        }

        private void SelectChange(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
