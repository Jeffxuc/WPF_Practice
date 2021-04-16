using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pr04_ButtonsAndOtherControls.SubItems
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : Window
    {
        public ComboBox()
        {
            InitializeComponent();
        }

    }

    public class ComboBoxData: ObservableCollection<string>
    {
        public ComboBoxData()
        {
            Add("A*****");
            Add("B*****");
            Add("C*****");
            Add("D*****");
            Add("E*****");
        }
    }
}
