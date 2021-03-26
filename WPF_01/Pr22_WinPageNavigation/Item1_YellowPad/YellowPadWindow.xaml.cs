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
using System.Windows.Ink;

namespace Pr22_WinPageNavigation.Item1_YellowPad
{
    /// <summary>
    /// Interaction logic for YellowPadWindow.xaml
    /// </summary>
    public partial class YellowPadWindow : Window
    {
        public static readonly double widthCanvas = 5 * 96;
        public static readonly double heightCanvas = 7 * 96;
        public YellowPadWindow()
        {            
            InitializeComponent();
            double y = 96;
            while(y<heightCanvas)
            {
                Line line = new Line();
                line.X1 = 0;
                line.Y1 = y;
                line.X2 = widthCanvas;
                line.Y2 = y;
                line.Stroke = Brushes.LightBlue;
                inkCav.Children.Add(line);
                y += 24;
            }
            if(Tablet.TabletDevices.Count==0)
            {
                menuEraserMode.Visibility = Visibility.Collapsed;
            }

        }
    }
}
