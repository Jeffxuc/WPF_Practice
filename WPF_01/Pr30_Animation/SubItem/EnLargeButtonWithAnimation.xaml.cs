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


/// <summary>
/// 通过DoubleAnimation来进行动画仿真
/// </summary>
namespace Pr30_Animation.SubItem
{
    /// <summary>
    /// Interaction logic for EnLargeButtonWithAnimation.xaml
    /// </summary>
    public partial class EnLargeButtonWithAnimation : Page
    {
        public double StartFontSize { get; } = 24;
        public double EndFontSize { get; } = 50;
        Button btn;

        public EnLargeButtonWithAnimation()
        {
            InitializeComponent();

            btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.FontFamily = new FontFamily("Times New Roman");
            btn.Content = "This is the Button change with Animation property.";
            btn.FontSize = StartFontSize;
            btn.Margin = new Thickness(24);
            Content = btn;

            btn.Click += OnBtnClicked;          
        }

        private void OnBtnClicked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation btnAnimate = new DoubleAnimation();
            btnAnimate.Duration = new Duration(TimeSpan.FromSeconds(2));
            btnAnimate.From = StartFontSize;
            btnAnimate.To = EndFontSize;
            btnAnimate.FillBehavior = FillBehavior.HoldEnd;

            btn.BeginAnimation(Button.FontSizeProperty, btnAnimate);
        }
    }
}
