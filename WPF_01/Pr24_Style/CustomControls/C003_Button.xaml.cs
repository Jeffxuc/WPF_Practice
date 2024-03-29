﻿using System;
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
using System.Windows.Threading;

namespace Pr24_Style.CustomControls
{
    /// <summary>
    /// Interaction logic for C003_Button.xaml
    /// </summary>
    public partial class C003_Button : Page
    {
        public C003_Button()
        {
            InitializeComponent();

            Button btn = new Button();
        }

        private void Btndel_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
        }

        private void Btnenable_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer durationTime = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 2),

            };

            durationTime.Tick += new EventHandler((sender1, e1) =>
            {
                tb10.Visibility = Visibility.Collapsed;
                durationTime.Stop();
            });

            durationTime.Start();
        }
    }
}
