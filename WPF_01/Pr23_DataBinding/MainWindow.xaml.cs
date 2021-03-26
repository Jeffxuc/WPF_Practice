using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr23_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // lb02以代码的形式来在后端进行绑定
            Binding bind = new Binding();
            bind.Source = scroll02;
            bind.Path = new PropertyPath(ScrollBar.ValueProperty);
            bind.Mode = BindingMode.Default; //绑定的模式，一般采取默认的，此处可省略
            lb02.SetBinding(ContentProperty, bind);

            
        }
    }
}
