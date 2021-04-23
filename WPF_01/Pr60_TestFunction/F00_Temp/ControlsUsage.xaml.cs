using Microsoft.Win32;
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

namespace Pr60_TestFunction.F00_Temp
{
    /// <summary>
    /// Interaction logic for ControlsUsage.xaml
    /// </summary>
    public partial class ControlsUsage : Window
    {
        public ControlsUsage()
        {
            InitializeComponent();

            Test ts = new Test()
            {
                str1 = "this is 01",
                str2 = "this is 02",
                num1 = 100
            };

            Test ts2 = new Test();
        }

        private void LoadFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Img Files(*.BMP;*.JPG;*.PNG;*.gif)|*.BMP;*.JPG;*.PNG;*.gif";
            openFileDialog.FilterIndex = 2;//在此没有作用，因为以上的Filter都在同一行显示的
            openFileDialog.ShowDialog();

            string imgPath = openFileDialog.FileName;
        }

        private void LoadFileBtn01_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"D:\MyFiles\04-Gif";
            dlg.Filter = "BMP file|*.BMP|JPG file|*.JPG|PNG File|*.PNG|JIF File|*.gif";
            dlg.FilterIndex = 4;
            dlg.ShowDialog();
           
        }

        private void Sp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = new TextBlock();
            tb.Text = "Hello Button be clicked";
            sp.Children.Add(tb);
        }
    }


    public class Test
    {
        public string str1;
        public int num1;
        public string str2;

        public Test()
        {

        }

        public Test(string str)
        {
            str1 = str;
        }
    }
}
