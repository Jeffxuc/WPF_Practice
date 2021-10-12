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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr30_Animation.SubItem
{
    /// <summary>
    /// Interaction logic for ColorRadioButtons.xaml
    /// </summary>
    public partial class ColorRadioButtons : Page
    {
        Storyboard cycleAnimateBoard = new Storyboard();
        public ColorRadioButtons()
        {
            InitializeComponent();

            btn01.Click += PreviewAnimation;

            GradientStopCollection gradientStops = new GradientStopCollection();
            GradientStop gradientStop1 = new GradientStop((Color)ColorConverter.ConvertFromString("#8A8890"), 0);
            GradientStop gradientStop2 = new GradientStop((Color)ColorConverter.ConvertFromString("#B0B0B0"), 0.39);
            GradientStop gradientStop3 = new GradientStop((Color)ColorConverter.ConvertFromString("#E6E6E6"), 0.63);
            GradientStop gradientStop4 = new GradientStop((Color)ColorConverter.ConvertFromString("#B0B0B0"), 1);
            gradientStops.Add(gradientStop1);
            gradientStops.Add(gradientStop2);
            gradientStops.Add(gradientStop3);
            gradientStops.Add(gradientStop4);

            LinearGradientBrush lgd = new LinearGradientBrush(gradientStops, 90);
            //lgd.StartPoint = new Point(0, 1);
            //lgd.EndPoint = new Point(1, 0);
            rec12.Fill = lgd;


        }

        private void PreviewAnimation(object sender, RoutedEventArgs e)
        {
            Color color1 = Color.FromRgb(0xff, 0xff, 0xff);
            Color color2 = Color.FromRgb(0x00, 0xff, 0xea);
            Color color3 = Color.FromRgb(0xee, 0x30, 0x58);
            Color color4 = Color.FromRgb(0x8b, 0x2d, 0xdf);

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0.5);
            gradientBrush.EndPoint = new Point(1, 0.5);
            GradientStop gradientStop1 = new GradientStop(color1, 0);
            GradientStop gradientStop2 = new GradientStop(color2, 0.4);
            GradientStop gradientStop3 = new GradientStop(color3, 0.7);
            GradientStop gradientStop4 = new GradientStop(color4, 1);

            gradientBrush.GradientStops.Add(gradientStop1);
            gradientBrush.GradientStops.Add(gradientStop2);
            gradientBrush.GradientStops.Add(gradientStop3);
            gradientBrush.GradientStops.Add(gradientStop4);

            rect.Fill = gradientBrush;

            //各种颜色循环切换显示
            Color[] colors = { color1, color2, color3, color4 };
            //for(int i=0;i<colors.Length-1;++i)
            //{
            //    ColorAnimation colorAnimation = new ColorAnimation
            //    {
            //        From = colors[i],
            //        To = colors[i + 1],
            //        BeginTime = TimeSpan.FromSeconds(i),
            //        Duration=TimeSpan.FromSeconds(1),
            //        AutoReverse=true,


            //    }
            //}

            
            




        }
    }
}
