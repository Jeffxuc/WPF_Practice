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
using System.Windows.Threading;
using WpfAnimatedGif;
using System.Windows.Media.Animation;

namespace Pr60_TestFunction.F04_CircleProgressBar
{
    /// <summary>
    /// Interaction logic for DisplayBar.xaml
    /// </summary>
    public partial class DisplayBar : Window
    {
        DispatcherTimer tm = new DispatcherTimer();
        public DisplayBar()
        {
            InitializeComponent();
            tm.Interval = TimeSpan.FromSeconds(2);
          

            BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/GifImg/theme_2_animation.gif"));
            ImageBehavior.SetAnimatedSource(gifImg, bitmapImage);
            ImageBehavior.SetRepeatBehavior(gifImg, new RepeatBehavior(1));

           
        }

        private void PreviewBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            previewBtn.Num += 10;
        }
    }
}
