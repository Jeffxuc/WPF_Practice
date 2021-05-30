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

namespace Pr60_TestFunction.F03_EventUsage
{
    /// <summary>
    /// Interaction logic for EventUsage.xaml
    /// </summary>
    public partial class EventUsage : Window
    {
        public EventUsage()
        {
            InitializeComponent();
            
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            tb00.Text = "Btn01 have been clicked";
            tb00.Background = Brushes.Azure;
            tb00.Foreground = Brushes.Red;
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            Btn10_Click(null, null);
        }
    }
}
