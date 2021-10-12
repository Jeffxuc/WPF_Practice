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

namespace Pr04_ButtonsAndOtherControls.SubItems
{
    /// <summary>
    /// Interaction logic for ScrollViewer_Usage.xaml
    /// </summary>
    public partial class ScrollViewer_Usage : Window
    {
        public ScrollViewer_Usage()
        {
            InitializeComponent();

            double pos1 = 0, pos2 = 0;

            btn01.Click += (s1, e1) =>
            {
                wp1.Visibility = Visibility.Visible;
                wp2.Visibility = Visibility.Collapsed;

                scv.ScrollToVerticalOffset(pos1);
            };

            btn02.Click += (s2, e2) =>
            {
                wp1.Visibility = Visibility.Collapsed;
                wp2.Visibility = Visibility.Visible;

                scv.ScrollToVerticalOffset(pos2);
            };

            scv.MouseLeave += (s3, e3) =>
            {
                if (wp1.Visibility == Visibility.Visible)
                {
                    pos1 = scv.ContentVerticalOffset;
                }

                if (wp2.Visibility == Visibility.Visible)
                {
                    pos2 = scv.ContentVerticalOffset;
                }
            };


        }
    }
}
