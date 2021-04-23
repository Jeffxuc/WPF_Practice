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

namespace Pr13_ListBox.SubItem
{
    /// <summary>
    /// Interaction logic for BindData2ItemsControl.xaml
    /// </summary>
    public partial class BindData2ItemsControl : Window
    {
        public BindData2ItemsControl()
        {
            InitializeComponent();
        }
    }

    //创建数据，内容均为单一的string类型
    public class MyData : ObservableCollection<string>
    {
        public MyData()
        {
            this.Add("Item 01");
            this.Add("Item 02");
            this.Add("Item 03");
            this.Add("Item 04");
            this.Add("Item 05");
            this.Add("Item 06");
            this.Add("Hello just a test.");
        }
    }


    
}
