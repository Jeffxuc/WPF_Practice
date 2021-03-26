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

namespace Pr07_Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Canvas cav2 = new Canvas();
            //cav2.HorizontalAlignment = HorizontalAlignment.Left;
            //cav2.Height = 80;
            //cav2.Width = mainGrid.Width;
            //Grid.SetRow(cav2, 4);

            ////在父子元素之间插入一个新元素，该插入元素为原父元素的孩子，为原孩子的父亲
            ////思路：先接触当前孩子与父元素的逻辑关系，再重新设置其父亲


            //if (tb2.Parent != null)
            //{
            //    //TextBlock temp = tb2;
            //    mainGrid.Children.Remove(tb2);
            //    cav2.Children.Add(tb2);

            //}

            //mainGrid.Children.Add(cav2);


        }
    }
}
