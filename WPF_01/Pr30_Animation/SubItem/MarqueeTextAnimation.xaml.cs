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
        Storyboard myStoryboard = new Storyboard();

        public MarqueeTextAnimation()
        {
            InitializeComponent();

            InitialSubContent();
            RegisterEvent();
        }


        private void Cav_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation textScroll = new DoubleAnimation();
            textScroll.From = -textBox01.ActualWidth;
            textScroll.To = cav.ActualWidth;
            textScroll.RepeatBehavior = RepeatBehavior.Forever;
            textScroll.Duration = TimeSpan.FromSeconds(8);
            textBox01.BeginAnimation(Canvas.LeftProperty, textScroll);
        }

        private void InitialSubContent()
        {
            // 1. Initial DoubleAnimate
            DoubleAnimation imgAnimate = new DoubleAnimation();
            imgAnimate.From = img02.Width;
            imgAnimate.To = -img02.Width;
            imgAnimate.Duration = TimeSpan.FromSeconds(6);
            imgAnimate.RepeatBehavior = RepeatBehavior.Forever;

            myStoryboard.Children.Add(imgAnimate);
            Storyboard.SetTarget(myStoryboard, img02);
            Storyboard.SetTargetProperty(myStoryboard, new PropertyPath(Canvas.LeftProperty));
        }

        private void RegisterEvent()
        {
            starMarqBtn.Click += MarqueeImgSimple;
            stopMarqBtn.Click += (s2, e2) =>
            {
                
            };


            preImg1Btn.Click += ClickPreviewImg01;

            preImg2Btn.Click += ClickPreviewImg02;

            preImg3Btn.Click += ClickPreviewImg03;

        }

        private void ClickPreviewImg01(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/Pr30_Animation;component/Images/personImg01.png"));
            img02.Source = bitmapImage;

            myStoryboard.Begin();
            
        }

        private void ClickPreviewImg02(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/Pr30_Animation;component/Images/personImg02.png"));
            img02.Source = bitmapImage;

            myStoryboard.Begin();
        }

        private void ClickPreviewImg03(object sender, RoutedEventArgs e)
        {
            myStoryboard.Stop();
            myStoryboard.Children.Clear();
        }

        private void MarqueeImgSimple(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = imgPrv.ActualWidth;
            doubleAnimation.To = -imgPrv.ActualWidth;
            doubleAnimation.Duration = TimeSpan.FromSeconds(6);
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            imgPrv.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
        }


    }
}
