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
using System.ComponentModel.Composition;
using PluginInterface;

namespace PluginB
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 
    [Export(typeof(IMyPlugin))]
    public partial class UserControl1 : UserControl,IMyPlugin
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public int GetPluginId()
        {
            return 1;
        }

        public string GetPluginName()
        {
            return "Plugin B page";
        }

        private void btn02_Clicked(object sender, RoutedEventArgs e)
        {
            if(lb01.IsVisible==false)
            {
                lb01.Visibility = Visibility.Visible;
            }
            else
            {
                lb01.Visibility = Visibility.Collapsed;
            }
        }
    }
}
