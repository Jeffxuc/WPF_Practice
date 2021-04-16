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

namespace Pr08_DependencyProperty.SubItems
{
    /// <summary>
    /// Interaction logic for CustomDPInSpaceButton.xaml
    /// </summary>
    public partial class CustomDPInSpaceButton : Window
    {
        public CustomDPInSpaceButton()
        {
            InitializeComponent();

            btn0.Content = "JustTest";

            btn1.Text = "JustTest";

            btn2.Text = "JustTest";
            btn2.Space = 2;

            btn3.Text= "JustTest";
            btn3.Space = 3;
        }
    }

    public class SpaceButton:Button
    {
        //1. 传统.NET定义方式：字段加属性
        private string _Text;
        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                Content = SpaceOutText(_Text);
            }
        }


        //2. 自定义 DependencyProperty
        public static readonly DependencyProperty SpaceProperty;
        public int Space //对自定义的DependencyProperty 进行封装
        {
            set
            {
                SetValue(SpaceProperty, value);
            }
            get
            {
                return (int)GetValue(SpaceProperty);
            }
        }

        static SpaceButton()
        {
            // 定义metadata
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.DefaultValue = 1;
            metadata.AffectsMeasure = true;
            metadata.Inherits = true;
            metadata.PropertyChangedCallback += OnSpacePropertyChanged;

            // 注册DependencyProperty
            SpaceProperty = DependencyProperty.Register("Space", typeof(int), typeof(SpaceButton), metadata,ValidateSpaceValue);
        }

        //回调方法：进行值的校验
        static bool ValidateSpaceValue(object obj)
        {
            int i = (int)obj;
            return i >= 0;
        }

        //回调方法：当property改变时
        static void OnSpacePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpaceButton btn = d as SpaceButton;
            btn.Content = btn.SpaceOutText(btn.Text);

        }

        //在文字中插入空白
        string SpaceOutText(string str)
        {
            if (str == null)
                return null;

            StringBuilder build = new StringBuilder();
            foreach(char ch in str)
            {
                build.Append(ch + new string(' ', Space));
            }
            return build.ToString();
        }
    }
}
