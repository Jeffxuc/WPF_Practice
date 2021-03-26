using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Pr30_Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EnLargeButtonWithTimer largeBtn;
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();

            largeBtn = new EnLargeButtonWithTimer();
            largeBtn.Show();
            DispatcherTimer disTimer = new DispatcherTimer();
            disTimer.Interval = TimeSpan.FromSeconds(0.1);
            disTimer.Tick += CheckTheStation;
            disTimer.Start();
        }

        private void CheckTheStation(object sender, EventArgs e)
        {
            if (!largeBtn.IsActive)
                this.Close();
        }
    }

    /// <summary>
    /// 点击按钮后，通过使用普通计时器来计来控制按钮的大小，在此未使用Animation的方式
    /// 该方式通用性更强。
    /// </summary>
    class EnLargeButtonWithTimer : Window
    {
        const double initFontSize = 12;
        const double maxFontSize = 80;
        Button btn01;

        public EnLargeButtonWithTimer()
        {
            Title = "EnLarge button with timer.";

            btn01 = new Button();
            btn01.Content = "Expand the Button 01";
            btn01.FontSize = initFontSize;
            btn01.HorizontalAlignment = HorizontalAlignment.Center;
            btn01.VerticalAlignment = VerticalAlignment.Center;
            Content = btn01;

            btn01.Click += OnBtnClicked;

        }

        private void OnBtnClicked(object sender, RoutedEventArgs e)
        {
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += OnBtnChange;
            timer.Start();
        }

        private void OnBtnChange(object sender, EventArgs e)
        {
            if(btn01.FontSize<maxFontSize)
            {
                btn01.FontSize += 2;
            }
            else
            {
                (sender as DispatcherTimer).Stop();
                btn01.Background = Brushes.BurlyWood;
                btn01.Foreground = Brushes.HotPink;
                btn01.FontFamily = new FontFamily("Times New Roman");
            }

        }
    }
}
