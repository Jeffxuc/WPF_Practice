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

namespace Pr03_ContentShowImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "Show Image Window"; //设置窗口的标题

            BorderBrush = Brushes.LightSkyBlue; //设置客户区边框的颜色
            BorderThickness = new Thickness(20); //设置客户区四周边框的宽度

            // 设置客户区的背景颜色为线性梯度
            LinearGradientBrush brush = new LinearGradientBrush(Colors.Red, Colors.Blue, new Point(0, 0), new Point(1, 1));
            Background = brush;

            /*//网络上加载图片方式一：
            Uri uri01=new Uri("https://baike.baidu.com/pic/Github/10145341/1/e824b899a9014c086e0641f5a33115087bf40ad15e02?fr=lemma&ct=single#aid=1&pic=e824b899a9014c086e0641f5a33115087bf40ad15e02");
            BitmapImage bitmapImage01 = new BitmapImage(uri01);
            Image img01 = new Image();
            img01.Source = bitmapImage01;
            Content = img01;*/

            /*//网络上加载图片方式二：
            BitmapImage bitmapImage02 = new BitmapImage();
            bitmapImage02.BeginInit();
            bitmapImage02.UriSource = new Uri("https://image.baidu.com/search/detail?ct=503316480&z=0&ipn=d&word=%E5%9B%BE%E6%A0%87&step_word=&hs=0&pn=0&spn=0&di=208120&pi=0&rn=1&tn=baiduimagedetail&is=0%2C0&istype=0&ie=utf-8&oe=utf-8&in=&cl=2&lm=-1&st=undefined&cs=3088040865%2C379235160&os=2176708355%2C921246892&simid=3328337303%2C135473827&adpicid=0&lpn=0&ln=1757&fr=&fmq=1612346321309_R&fm=&ic=undefined&s=undefined&hd=undefined&latest=undefined&copyright=undefined&se=&sme=&tab=0&width=undefined&height=undefined&face=undefined&ist=&jit=&cg=&bdtype=0&oriquery=&objurl=https%3A%2F%2Fgimg2.baidu.com%2Fimage_search%2Fsrc%3Dhttp%3A%2F%2Fimg.sfw.cn%2Fadmin%2Fw%2Fnews%2Fuploadfile%2F20130621095037713%2F201306210152418175.png%26refer%3Dhttp%3A%2F%2Fimg.sfw.cn%26app%3D2002%26size%3Df9999%2C10000%26q%3Da80%26n%3D0%26g%3D0n%26fmt%3Djpeg%3Fsec%3D1614938324%26t%3Dcf677c75d7d8e42d60b2f71937f3433e&fromurl=ippr_z2C%24qAzdH3FAzdH3Ffwuj4jg8lld_z%26e3Bv54AzdH3Ft5f88%2Btv5g%25E0%25ld%25b8%25Em%25bD%25la%25EE%25bc%25Bb%25E0%25l8%25ll%25Ec%25bB%25AE%25Ec%25AF%25lmAzdH3F&gsm=1&rpstart=0&rpnum=0&islist=&querylist=&force=undefined");
            bitmapImage02.EndInit();
            Image img02 = new Image();
            img02.Source = bitmapImage02;
            this.Content = img02;*/

            /*//加载本地图片(绝对路径)
            Uri uri03 = new Uri("D:\\Temp\\img01.jpg");
            BitmapImage bitmapImage03 = new BitmapImage(uri03);
            Image img03 = new Image();
            img03.Source = bitmapImage03;
            img03.Stretch = Stretch.Fill; //可设置图像填满整个窗口区域
            img03.Opacity = 0.8; //设置图片的透明度，默认为不透明的
            Content = img03;*/

            /*// 设置内容为椭圆形状
            Ellipse elip = new Ellipse();
            elip.Fill = Brushes.BlueViolet; //设置椭圆内填充的颜色
            elip.StrokeThickness = 3; //椭圆边线的宽度
            elip.Stroke = Brushes.Black; //椭圆边线的颜色，默和Windows对象一样，这样就看不见了
            elip.Width = 400; //椭圆的尺寸
            elip.Height = 300;
            Content = elip;*/



            TextBlock text = new TextBlock();
            text.FontSize = 20;
            text.FontFamily = new FontFamily("Times New Roman");
            Content = text;
            string str = "Hello just a test.";
            string[] words = str.Split(' ');

            foreach(var s in words)
            {
                Run run = new Run(s);
                run.MouseDown += RunOnMouseDown;
                text.Inlines.Add(run);
                text.Inlines.Add("--");
            }
        }

        private void RunOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Run run = sender as Run;

        }
    }
}
