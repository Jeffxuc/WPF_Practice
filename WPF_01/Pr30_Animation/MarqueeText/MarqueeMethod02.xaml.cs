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

namespace Pr30_Animation.MarqueeText
{
    /// <summary>
    /// Interaction logic for MarqueeMethod02.xaml
    /// </summary>
    public partial class MarqueeMethod02 : Page
    {
        Canvas pageCav;
        Canvas InCav;
        TextBlock tblock;
        public MarqueeMethod02()
        {
            InitializeComponent();

            //通过代码来将创建的控件加入到当前页面中
            pageCav = new Canvas();
            Grid.SetRow(pageCav, 3);
            Grid.SetColumn(pageCav, 1);

            tblock = new TextBlock();
            tblock.Name = "txtblock";
            tblock.Text = "Panel 1:The first part.Panel 2:The second part.";
            tblock.FontSize = 20;
            tblock.Background = Brushes.DarkSeaGreen;
            tblock.Opacity = 0.7;
            tblock.HorizontalAlignment = HorizontalAlignment.Center;
            tblock.VerticalAlignment = VerticalAlignment.Center;
            Canvas.SetTop(tblock, 15);
            Canvas.SetLeft(tblock, 27);
            

            pageCav.Background = Brushes.DarkSlateBlue;
            pageCav.Name = "cavShow";
            pageCav.ClipToBounds = true;
            
            pageCav.Children.Add(tblock);
            gd.Children.Add(pageCav);


            string str = "hello this\n is\n just a \ntest";
            string res = str.Replace("\n", "@");
            
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*DoubleAnimation dbAnimate = new DoubleAnimation();
            dbAnimate.From = Canvas.GetLeft(tblock);
            dbAnimate.To = -tblock.ActualWidth;
            dbAnimate.BeginTime = TimeSpan.FromSeconds(1);
            dbAnimate.Duration = TimeSpan.FromSeconds(6);
            dbAnimate.RepeatBehavior = RepeatBehavior.Forever;
            tblock.BeginAnimation(Canvas.LeftProperty, dbAnimate);*/


            DoubleAnimation animate = new DoubleAnimation();
            animate.From = Canvas.GetLeft(tb44);
            animate.To = -tb44.ActualWidth;
            animate.BeginTime = TimeSpan.FromSeconds(2);
            animate.Duration = TimeSpan.FromSeconds(5);
            animate.RepeatBehavior = RepeatBehavior.Forever;
            tb44.BeginAnimation(Canvas.LeftProperty, animate);

        }    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation scrollAnimate = new DoubleAnimation();
            scrollAnimate.From = 0;
            scrollAnimate.To = -marquee.ActualWidth;
            scrollAnimate.BeginTime = TimeSpan.FromSeconds(0.5);
            scrollAnimate.RepeatBehavior = RepeatBehavior.Forever;
            scrollAnimate.Duration = TimeSpan.FromSeconds(6);
            marquee.BeginAnimation(Canvas.LeftProperty, scrollAnimate);
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation textScroll = new DoubleAnimation();
            textScroll.From = 0;
            textScroll.To = -tb12.ActualWidth;
            textScroll.BeginTime = TimeSpan.FromSeconds(0.5);
            textScroll.Duration = TimeSpan.FromSeconds(7);
            textScroll.RepeatBehavior = RepeatBehavior.Forever;
            tb12.BeginAnimation(Canvas.LeftProperty, textScroll);
            
        }

        

        /*private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation textScroll = new DoubleAnimation();
            textScroll.From = 0;
            textScroll.To = -tb12.ActualWidth;
            textScroll.BeginTime = TimeSpan.FromSeconds(0.5);
            textScroll.Duration = TimeSpan.FromSeconds(8);
            textScroll.RepeatBehavior = RepeatBehavior.Forever;
            tb12.BeginAnimation(Canvas.LeftProperty, textScroll);
        }*/
    }
}
