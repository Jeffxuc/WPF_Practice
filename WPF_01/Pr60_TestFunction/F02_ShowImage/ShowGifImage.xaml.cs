﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace Pr60_TestFunction.F02_ShowImage
{
    /// <summary>
    /// Interaction logic for ShowGifImage.xaml
    /// </summary>
    public partial class ShowGifImage : Page
    {
        public ShowGifImage()
        {
            InitializeComponent();

            BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/theme_2_animation.gif"));
            Image image = new Image();
            image.Margin = new Thickness(10);
            ImageBehavior.SetAnimatedSource(image, bitmapImage);

            Slider slider = new Slider();
            slider.Maximum = 3;
            slider.Minimum = 1;
            slider.Value = 2;
            slider.Orientation = Orientation.Horizontal;
            slider.Width = 300;
            slider.SmallChange = 1;
            slider.TickFrequency = 1;                      
            
            /******* Control Layout ********/
            mainGrid.Children.Add(image);
            Grid.SetRow(image,0);
            Grid.SetColumn(image,1);

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Background = Brushes.Beige
            };

            TextBlock txt = new TextBlock();
            txt.FontSize = 20;
            txt.Margin = new Thickness(6);
            txt.HorizontalAlignment = HorizontalAlignment.Center;
            txt.Text = "showSpeed";
            

            mainGrid.Children.Add(sp);
            Grid.SetRow(sp, 1);
            Grid.SetColumn(sp, 1);
            sp.Children.Add(slider);
            sp.Children.Add(txt);

            Binding bind = new Binding();
            bind.Source = slider;
            bind.Path = new PropertyPath(Slider.ValueProperty);
            bind.Mode = BindingMode.Default;
            txt.SetBinding(TextBlock.TextProperty, bind);

            // 将Gif动画的速度值绑定到Slider上
            Binding bindspeed = new Binding();
            bindspeed.Source = slider;
            bindspeed.Path = new PropertyPath(Slider.ValueProperty);
            image.SetBinding(ImageBehavior.AnimationSpeedRatioProperty, bindspeed); 
 
        }

        private void BtnOnPlay_Click(object sender, RoutedEventArgs e)
        {
            int repeatTime = int.Parse(inputTxt.Text);

            BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/theme_2_animation.gif"));
            Image image = new Image();
            ImageBehavior.SetAnimatedSource(image, bitmapImage);
            grid20.Children.Add(image);

            ImageBehavior.SetRepeatBehavior(image, new RepeatBehavior(repeatTime));
            //var controller = ImageBehavior.GetAnimationController(image);
            ImageBehavior.AddAnimationCompletedHandler(image, new RoutedEventHandler((sender1, e1) => ComplateTheGIF(sender1, e1)));

        }

        private void ComplateTheGIF(object sender, RoutedEventArgs e)
        {
            Image im=sender as Image;
            grid20.Children.Remove(im);
        }

        private void BtnMultiGifPlay(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage1 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/theme_2_animation.gif"));
            BitmapImage bitmapImage2 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/Time_information_24.gif"));
            Image image1 = new Image();
            Image image2 = new Image();
            ImageBehavior.SetAnimatedSource(image1, bitmapImage1);
            ImageBehavior.SetAnimatedSource(image2, bitmapImage2);
            ImageBehavior.SetRepeatBehavior(image1, new RepeatBehavior(1));
            ImageBehavior.SetRepeatBehavior(image2, new RepeatBehavior(1));
            grid22.Children.Add(image1);
            ImageBehavior.AddAnimationCompletedHandler(image1, new RoutedEventHandler((s1, e1) => Img1Complete(s1, e1, image2)));
            ImageBehavior.AddAnimationCompletedHandler(image2, new RoutedEventHandler((s2, e2) => Img2Complete(s2, e2)));

        }

        private void Img2Complete(object s2, RoutedEventArgs e2)
        {
            Image img2 = s2 as Image;
            grid22.Children.Remove(img2);
        }

        private void Img1Complete(object s1, RoutedEventArgs e1, Image img2)
        {
            Image img1 = s1 as Image;
            grid22.Children.Remove(img1);
            grid22.Children.Add(img2);
        }

        private void SwitchGifPngAnimate(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage1 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/trending_animation_s1.gif"));
            Image imgGif = new Image();
            ImageBehavior.SetAnimatedSource(imgGif, bitmapImage1);
            ImageBehavior.SetRepeatBehavior(imgGif, new RepeatBehavior(1));
            grid30.Children.Add(imgGif);
            ImageBehavior.AddAnimationCompletedHandler(imgGif, new RoutedEventHandler((s1, e1) =>
             {
                 Image img1 = s1 as Image;
                 img1.Visibility = Visibility.Collapsed;
                 
             }));

            Image imgPng = new Image();
            BitmapImage bitmapImage2 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/text display_256x64_1.png"));
            imgPng.Source = bitmapImage2;
            imgPng.Visibility = Visibility.Collapsed;
            grid30.Children.Add(imgPng);
        }
    }
}
