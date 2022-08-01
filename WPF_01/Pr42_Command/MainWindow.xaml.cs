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

namespace Pr42_Command
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeCommand();

            RegisterEvent();
        }

        #region 1. 后台通过C#代码来进行绑定对应的命令
        //声明并自定义路由命令：clearCmd
        private RoutedCommand clearCmd = new RoutedCommand("Clear TextBox", typeof(Window));

        private void InitializeCommand()
        {
            btn01.Command = clearCmd;
            clearCmd.InputGestures.Add(new KeyGesture(Key.W, ModifierKeys.Alt));
            btn01.CommandTarget = tb01;

            CommandBinding cmdBind = new CommandBinding();
            cmdBind.Command = clearCmd;
            cmdBind.CanExecute += CmdBind_CanExecute;
            cmdBind.Executed += CmdBind_Executed;

            grid.CommandBindings.Add(cmdBind);

        }

        private void CmdBind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tb01.Clear();
            e.Handled = true;
        }

        private void CmdBind_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb01.Text))
                e.CanExecute = false;
            else
                e.CanExecute = true;

            e.Handled = true;
        }
        #endregion


        #region 2. XAML 端进行绑定，后端实现对应的逻辑：CanExecute, Executed
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
                e.CanExecute = false;
            else
                e.CanExecute = true;

            e.Handled = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if(e.Parameter.ToString()== "Teacher")
            {
                subItem.Items.Add(string.Format("Add New Teacher: {0}", nameTxt.Text));
            }
            else if(e.Parameter.ToString()== "Student")
            {
                subItem.Items.Add(string.Format("Add New Student: {0}", nameTxt.Text));
            }
        }

        #endregion


        #region 3. 不使用Command，使用事件Event来进行实现
        private void RegisterEvent()
        {
            techBtn.Click += (s1, e1) =>
            {
                showItem.Items.Add(string.Format("Teacher, name is: {0}", inputTxt.Text));
            };

            stuBtn.Click += (s2, e2) =>
            {
                showItem.Items.Add(string.Format("Student, name is: {0}", inputTxt.Text));
            };


            inputTxt.TextChanged += (s3, e3) =>
            {
                if (string.IsNullOrEmpty(inputTxt.Text))
                {
                    techBtn.IsEnabled = false;
                    stuBtn.IsEnabled = false;
                }
                else
                {
                    techBtn.IsEnabled = true;
                    stuBtn.IsEnabled = true;
                }
            };

            if(string.IsNullOrEmpty(inputTxt.Text))
            {
                techBtn.IsEnabled = false;
                stuBtn.IsEnabled = false;
            }
        }

        #endregion

    }
}
