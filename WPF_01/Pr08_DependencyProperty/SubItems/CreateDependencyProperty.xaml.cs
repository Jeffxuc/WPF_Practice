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
    /// Interaction logic for CreateDependencyProperty.xaml
    /// </summary>
    public partial class CreateDependencyProperty : Window
    {
        //1.自定义的简单依赖属性
        public static readonly DependencyProperty CustomDataProperty =
            DependencyProperty.Register("CustomData", typeof(int), typeof(CreateDependencyProperty), new PropertyMetadata(0));
        public int CustomData
        {
            get { return (int)GetValue(CustomDataProperty); }
            set { SetValue(CustomDataProperty, value); }
        }


        //2.定义传统的属性：字段+封装的属性，如：curTxt
        private string _curTxt;
        public string curTxt
        {
            get
            {
                return _curTxt;
            }
            set
            {
                if (value != null)
                {
                    _curTxt = value;
                    btn01.Content = value;
                }
            }
        }

        public CreateDependencyProperty()
        {
            InitializeComponent();

            //每个控件都有DataContext属性，且它作为默认的绑定源，可以指定它的取值。
            //this.DataContext = new TestA();
            this.DataContext = new DpData();

            //通过普通属性关联动态改变Button的值。
            inputTxt.TextChanged += (s1, e1) =>
            {
                curTxt = inputTxt.Text;
            };
            
        }
    }



    // 定义依赖属性的类必须要继承自DependencyObject(无论间接还是直接)，因为DependencyProperty本身并不提供
    // 对属性的取值赋值操作，而是由DependencyObject来负责这些操作
    public class TestA: DependencyObject
    {

        //属性包装器，用GetValue和SetValue来对属性Name进行包装
        public string  Name
        {
            get { return (string )GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        // PropertyMetadata为属性元数据，它具有5个对应的构造函数
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string ), typeof(TestA), new PropertyMetadata("Hi Dp",propertyChangeCallBack));

        
        // 属性变化的回调函数，当属性值变化时，会触发该函数的调用
        private static void propertyChangeCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TestA ts1 = d as TestA;
            ts1.Name = (string)e.NewValue;
        }
    }



    // 2.定义依赖属性类型
    public class DpData : DependencyObject
    {
        public DpData()
        {
            grade = 8;
        }

        // grade 为CLR属性，即普通常规属性
        public int grade { get; set; }


        // 依赖属性包装为CLR属性
        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // AgeProperty 为自定义的依赖属性
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(DpData), new PropertyMetadata(10, new PropertyChangedCallback(AgeChangedCallBack)), new ValidateValueCallback(validAgeCallBack));


        //当Age值变化时，调用此函数
        private static void AgeChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DpData dp = d as DpData;
            dp.grade = (int)e.NewValue;
        }

        //校验设定的值是否合法。该委托函数作为参数可省略掉
        private static bool validAgeCallBack(object value)
        {
            int curAge = (int)value;
            if (curAge < 0 || curAge > 200)
                return false;
            return true;
        }
    }
}
