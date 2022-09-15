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
        static int count = 0;

        public SourceNotifyPropertyChanged()
        {
            this.DataContext = myData;  // Attention: DataContext 一定是上面所 New 出来的，或者是XAML中实例的

            InitializeComponent();

            //在后台实现对自定义属性的绑定：单一绑定
            Binding binding = new Binding();
            binding.Source = myData;
            binding.Path = new PropertyPath("Num");
            binding.Mode = BindingMode.OneWay;
            txt00.SetBinding(TextBlock.TextProperty, binding);


            // 后台 Code 实现: 多重绑定，必须要设置绑定的StringFormat 或者 Converter
            MultiBinding multiBinding = new MultiBinding();
            multiBinding.StringFormat = "{0} ++++ {1}";
            multiBinding.Bindings.Add(new Binding("Msg_errorinfo") { Source = myData });
            multiBinding.Bindings.Add(new Binding("Msg_errorCode") { Source = myData });
            tb31.SetBinding(TextBlock.TextProperty, multiBinding);

        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            count++;

            myData.Num++;

            myData.Msg_errorCode = count.ToString();
        }
    }


    // 1.定义 .NET 普通数据类型
    public class NormalData : INotifyPropertyChanged
    {
        public NormalData()
        {
            Num = 88;
            city = "suzhou";

            Msg_errorCode = "0";
            Msg_errorinfo = "Show error infomations.";
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

        private string msg_errorInfo;
        public string Msg_errorinfo
        {
            get { return msg_errorInfo; }
            set
            {
                if(msg_errorInfo!=value)
                {
                    msg_errorInfo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string msg_errorCode;
        public string Msg_errorCode
        {
            get { return msg_errorCode; }
            set
            {
                if(msg_errorCode!=value)
                {
                    msg_errorCode = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
