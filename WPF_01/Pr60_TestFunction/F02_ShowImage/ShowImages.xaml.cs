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

namespace Pr60_TestFunction.F02_ShowImage
{
    /// <summary>
    /// Interaction logic for ShowImages.xaml
    /// </summary>
    public partial class ShowImages : Window
    {
        public ShowImages()
        {
            InitializeComponent();

            /***********  方法1： ************/
            Uri uri01 = new Uri(@"D:\WSpace\ImgFile\Natural\12.jpeg");
            BitmapImage bitmapImage01 = new BitmapImage(uri01);
            Image image01 = new Image();
            image01.Source = bitmapImage01;

            mainGrid.Children.Add(image01);
            Grid.SetRow(image01, 0);
            Grid.SetColumn(image01, 1);

            /***********  方法2： ************/
            // 创建图片的Source
            BitmapImage bitmapImage02 = new BitmapImage();
            bitmapImage02.BeginInit();
            bitmapImage02.UriSource = new Uri(@"D:\WSpace\ImgFile\Natural\13.jpeg");// BitmapImage.UriSource 必须在 BeginInit/EndInit 之间
            bitmapImage02.EndInit();
            //创建Image对象，并将其Source设定为位图
            Image image02 = new Image();
            image02.Source = bitmapImage02;

            mainGrid.Children.Add(image02);
            Grid.SetRow(image02, 0);
            Grid.SetColumn(image02, 2);

            //加载项目资源中的图片
            Uri uri03 = new Uri("pack://application:,,,/Pr60_TestFunction;component/F02_ShowImage/Images/05.jpeg");
            BitmapImage bitmapImage03 = new BitmapImage(uri03);
            Image image03 = new Image();
            image03.Source = bitmapImage03;

            mainGrid.Children.Add(image03);
            Grid.SetRow(image03, 2);
            Grid.SetColumn(image03, 0);

           
        }
    }
}
