using System;
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
using System.Windows.Threading;
using WpfAnimatedGif;

namespace Pr60_TestFunction.F02_ShowImage
{
    /// <summary>
    /// Interaction logic for ShowGifImage.xaml
    /// </summary>
    public partial class ShowGifImage : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        ImageAnimationController gifSpeedController = null;

        Image image03 = new Image();

        public ShowGifImage()
        {
            InitializeComponent();
            Image img = new Image();

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


            //Grid0/3
            BitmapImage bitmapImage03 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/theme_2_animation.gif"));
            image.Margin = new Thickness(10);
            ImageBehavior.SetAnimatedSource(image03, bitmapImage03);
            gif.Children.Add(image03);


            // Get the speed ratio of gif.
            ImageBehavior.AddAnimationLoadedHandler(ImgS3, new RoutedEventHandler((s2, e2) =>
            {
                gifSpeedController = ImageBehavior.GetAnimationController(ImgS3);
            }));

        }

        #region
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
            //洗版动画Gif图
            BitmapImage bitmapImage1 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/trending_animation_s1.gif"));
            Image imgGif = new Image();
            
            ImageBehavior.SetAnimatedSource(imgGif, bitmapImage1);
            ImageBehavior.SetRepeatBehavior(imgGif, new RepeatBehavior(1));
            grid30.Children.Add(imgGif);

            ImageAnimationController gifController = null;
            //******** GetAnimationController will return null if the animation is not yet fully loaded ***********
            ImageBehavior.AddAnimationLoadedHandler(imgGif, new RoutedEventHandler((s2, e2) =>
             {
                 gifController = ImageBehavior.GetAnimationController(imgGif);
             }));


            //静态PNG图
            Image imgPng = new Image();
            BitmapImage bitmapImage2 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/text display_256x64_1.png"));
            imgPng.Source = bitmapImage2;
            imgPng.Visibility = Visibility.Collapsed;
            grid30.Children.Add(imgPng);

            //计时器
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Tick += (object s3, EventArgs e3) =>
            {
                //grid30.Children[0].Visibility = Visibility.Visible;
                //grid30.Children[1].Visibility = Visibility.Collapsed;
                imgGif.Visibility = Visibility.Visible;
                imgPng.Visibility = Visibility.Collapsed;

                dispatcherTimer.Stop();

                gifController.GotoFrame(0);
                gifController.Play();
            };

            ImageBehavior.AddAnimationCompletedHandler(imgGif, new RoutedEventHandler((s1, e1) =>
             {
                 //grid30.Children[0].Visibility = Visibility.Collapsed;
                 //grid30.Children[1].Visibility = Visibility.Visible;
                 imgGif.Visibility = Visibility.Collapsed;
                 imgPng.Visibility = Visibility.Visible;

                 //gifController.Pause();
                 dispatcherTimer.Start();
             }));


            //dispatcherTimer.Tick += new EventHandler((object s3, EventArgs e3) => PngEnd(s3, e3));
            //ImageBehavior.AddAnimationCompletedHandler(imgGif, new RoutedEventHandler((object s1, RoutedEventArgs e1) => GifEnd(s1, e1)));

        }

        private void Btns1_Click(object sender, RoutedEventArgs e)
        {
            ImageBehavior.GetAnimationSpeedRatio(image03);
            ImageBehavior.SetAnimationSpeedRatio(image03, 2);
            ImageBehavior.SetRepeatBehavior(image03, new RepeatBehavior(2));
            ImageBehavior.GetAnimationSpeedRatio(image03);
        }

        private void Btns2_Click(object sender, RoutedEventArgs e)
        {
            ImageBehavior.SetAnimationSpeedRatio(image03, 3);
            ImageBehavior.SetRepeatBehavior(image03, new RepeatBehavior(3));
            
        }

        private void Btns3_Click(object sender, RoutedEventArgs e)
        {
            ImageBehavior.SetAnimationSpeedRatio(image03, 4);
            ImageBehavior.SetRepeatBehavior(image03, new RepeatBehavior(4));
            //gif.Children.Clear();
        }

        private void Tbtn_Click(object sender, RoutedEventArgs e)
        {
            bool? flage = tbtn.IsChecked;
        }

        private void Tbtn_Checked(object sender, RoutedEventArgs e)
        {
            bool? flage = tbtn.IsChecked;
        }

        private void Tbtn_Unchecked(object sender, RoutedEventArgs e)
        {
            bool? flage = tbtn.IsChecked;
        }

        private void RadioBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioBtn_Unchecked(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        private void GetSpeed_Click(object sender, RoutedEventArgs e)
        {
            //ImageAnimationController gifSpeedController = null;
            //ImageBehavior.AddAnimationLoadedHandler(ImgS2, new RoutedEventHandler((s2, e2) =>
            //{
            //    gifSpeedController = ImageBehavior.GetAnimationController(ImgS2);
            //}));

            if(gifSpeedController != null)
            {
                //double? speedRatio = ImageBehavior.GetAnimationSpeedRatio();
                //Duration? duration = ImageBehavior.GetAnimationDuration(ImgS2);
                TimeSpan tp = gifSpeedController.Duration;
                
            }

        }
    }
}
