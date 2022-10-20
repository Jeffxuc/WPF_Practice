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

namespace Pr23_DataBinding.ConvertValueType
{
    /// <summary>
    /// Interaction logic for DecimalScrollBarWindow.xaml
    /// </summary>
    public partial class DecimalScrollBarWindow : Window
    {
        public DecimalScrollBarWindow()
        {
            InitializeComponent();

            btn01.Click += (s1, e1) =>
            {
                if (btn01.BorderThickness == new Thickness(0))
                {
                    btn01.BorderThickness = new Thickness(1);
                }
                else
                {
                    btn01.BorderThickness = new Thickness(0);
                }
            };

            btn02.Click += (s2, e2) =>
            {
                if (btn02.BorderThickness == new Thickness(0))
                {
                    btn02.BorderThickness = new Thickness(1);
                    lb_01.Visibility = Visibility.Visible;
                }
                else
                {
                    btn02.BorderThickness = new Thickness(0);
                    lb_01.Visibility = Visibility.Collapsed;
                }
            };


        }
    }
}
