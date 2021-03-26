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
using System.Windows.Media.Animation;

namespace Pr30_Animation.SubItem
{
    /// <summary>
    /// Interaction logic for MarqueeTextAnimation.xaml
    /// </summary>
    public partial class MarqueeTextAnimation : Page
    {
        public MarqueeTextAnimation()
        {
            InitializeComponent();    
        }


        private void Cav_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation textScroll = new DoubleAnimation();
            textScroll.From = -textBox01.ActualWidth;
            textScroll.To = cav.ActualWidth;
            textScroll.RepeatBehavior = RepeatBehavior.Forever;
            textScroll.Duration = TimeSpan.FromSeconds(2);
            textBox01.BeginAnimation(Canvas.LeftProperty, textScroll);
        }
    }
}
