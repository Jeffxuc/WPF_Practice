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

namespace Pr08_DependencyProperty.SubItems
{
    /// <summary>
    /// Interaction logic for CreateDependencyProperty.xaml
    /// </summary>
    public partial class CreateDependencyProperty : Window
    {
        public static readonly DependencyProperty CustomDataProperty =
            DependencyProperty.Register("CustomData", typeof(int), typeof(int), new PropertyMetadata(0));
        public int CustomData
        {
            get { return (int)GetValue(CustomDataProperty); }
            set { SetValue(CustomDataProperty, value); }
        }

        

        public CreateDependencyProperty()
        {
            InitializeComponent();
        }
    }
}
