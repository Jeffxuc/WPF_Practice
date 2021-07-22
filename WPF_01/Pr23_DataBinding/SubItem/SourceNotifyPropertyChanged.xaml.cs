using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Pr23_DataBinding.SubItem
{
    /// <summary>
    /// Interaction logic for SourceNotifyPropertyChanged.xaml
    /// </summary>
    public partial class SourceNotifyPropertyChanged : Window
    {
        NormalData myData = new NormalData();

        public SourceNotifyPropertyChanged()
        {
            this.DataContext = new NormalData();

            InitializeComponent();

            //在后台实现对自定义属性的绑定
            Binding binding = new Binding();
            binding.Source = myData;
            binding.Path = new PropertyPath("Num");
            binding.Mode = BindingMode.OneWay;
            txt00.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            myData.Num++;
        }
    }


    // 1.定义 .NET 普通数据类型
    public class NormalData : INotifyPropertyChanged
    {
        public NormalData()
        {
            Num = 88;
            city = "suzhou";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private int num = 99;
        public int Num
        {
            get { return num; }
            set
            {
                if (num != value)
                {
                    num = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string city;
        public string City
        {
            get { return city; }
            set
            {
                if(city !=value)
                {
                    city = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
