using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pr04_ButtonsAndOtherControls.SubItems
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox_Usage : Window
    {
        public ComboBox_Usage()
        {
            InitializeComponent();

            combox02.SelectionChanged += (object sender, SelectionChangedEventArgs e) =>
            {
                //将选中的项目解析成对应的类型，然后再来获取它的值
                TextBlock cur = (sender as ComboBox).SelectedItem as TextBlock;
                //if (cur.Text == "02")
                //{
                //    showCurTxt.Text = cur.Text;
                //}
                showCurTxt.Text = cur.Text;
            };


        }

    }

    public class ComboBoxData: ObservableCollection<string>
    {
        public ComboBoxData()
        {
            Add("A*****");
            Add("B*****");
            Add("C*****");
            Add("D*****");
            Add("E*****");
        }
    }
}
