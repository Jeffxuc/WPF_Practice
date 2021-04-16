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


    // 自定义数据类型
    public class MyTask
    {
        public int TaskPriority { set; get; }
        public string TaskName { set; get; }
        public string TaskDescription { set; get; }

        public MyTask(int taskPriority,string taskName,string taskDescription)
        {
            TaskPriority = taskPriority;
            TaskName = taskName;
            TaskDescription = taskDescription;
        }
    }
    // 设置绑定数据的类型
    public class MyTodoList:ObservableCollection<MyTask>
    {
        public MyTodoList()
        {
            Add(new MyTask(2, "Shopping", "go to shopping today"));
            Add(new MyTask(2, "Laundry", "need to Laundry" ));
            Add(new MyTask(1, "Email", "Remember set a email" ));
            Add(new MyTask(3,"Clean","Clean my Office" ));
            Add(new MyTask(1, "Dinner", "go to dinner" ));
            Add(new MyTask(2, "Proposals", "make a Proposals" ));
        }
    }

    //自定义绑定的数据类型
    public class ProgressData
    {
        public string ItemName { set; get; }
        public int ProgressNum { set; get; }

        public ProgressData(string itemName,int progressNum)
        {
            ItemName = itemName;
            ProgressNum = progressNum;
        }
    }

    public class MyProgress:ObservableCollection<ProgressData>
    {
        public MyProgress()
        {
            Add(new ProgressData("C++", 70));
            Add(new ProgressData("C#", 90));
            Add(new ProgressData("Linux", 60));
            Add(new ProgressData("Linux", 60));
            Add(new ProgressData("Linux", 60));
            Add(new ProgressData("Linux", 60));
            Add(new ProgressData("Linux", 60));
        }
    }
}
