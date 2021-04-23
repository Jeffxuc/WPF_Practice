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
using Pr04_ButtonsAndOtherControls.SubItems;

namespace Pr04_ButtonsAndOtherControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Run run;

        public MainWindow()
        {
            InitializeComponent();
            Title = "Formate the Text in button";

            Button btn01 = new Button();
            btn01.VerticalAlignment = VerticalAlignment.Center;
            btn01.HorizontalAlignment = HorizontalAlignment.Center;
            btn01.Padding = new Thickness(20);
            btn01.MouseEnter += BtnMouseEnter; //鼠标进入时触发该事件
            btn01.MouseLeave += BtnMouseLeave; //鼠标离开时触发该事件
            this.Content = btn01;

            TextBlock txtBlock = new TextBlock();
            txtBlock.FontSize = 20;
            // 往文本中添加不同格式的字符串
            txtBlock.Inlines.Add("Hello");
            txtBlock.Inlines.Add(" ");
            txtBlock.Inlines.Add(new Italic(new Run("Just a")));
            txtBlock.Inlines.Add(new Bold(new Run(" Test ")));
            txtBlock.Inlines.Add(run=new Run(" @Thanks@"));
            txtBlock.Foreground = Brushes.Red;


            btn01.Content = txtBlock;

            btn01.Click += Click_Btn01;
        

            // 2-新开窗体在按钮中显示图片
            //ClickBtnShowPicture btnWin = new ClickBtnShowPicture();
            //btnWin.Show();

            // 3-命令绑定到按钮上
            //CommandBindBtn cmdbtn = new CommandBindBtn();
            //cmdbtn.Show();

            //4-切换按钮控件
            /*ToggleTheButton tgWin = new ToggleTheButton();
            tgWin.Show();
            tgWin.Topmost = true;//用来控制当前窗口位于所有窗口的最上面。*/

            /*UseUriDialogNavigate navWeb = new UseUriDialogNavigate();
            navWeb.Show();
            navWeb.Topmost = true;*/


            // 文本编辑实例
            EditText editText = new EditText();
            editText.Show();
            editText.Topmost = true;


        }

        private void BtnMouseLeave(object sender, MouseEventArgs e)
        {
            run.Foreground = Brushes.Yellow;
        }

        private void BtnMouseEnter(object sender, MouseEventArgs e)
        {
            run.Foreground = Brushes.SeaShell;
        }

        private void Click_Btn01(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have clicked me ");
        }
    }

    /// <summary>
    /// 2-按钮以图片来进行填充
    /// </summary>
    public class ClickBtnShowPicture:Window
    {
        //将图片变成项目的资源，此时图片将称为项目的一部分被编译
        public ClickBtnShowPicture()
        {
            Title = "Image on the Button";
            Uri uri01 = new Uri("pack://application:,,/Images/img01.jpeg"); //在项目资源中加载图片
            Uri uri02 = new Uri("pack://application:,,/Images/img02.jpeg");
            BitmapImage bitmap = new BitmapImage(uri02);
            Image img01 = new Image();
            img01.Source = bitmap;
            img01.Stretch = Stretch.Uniform;
            img01.Opacity = 0.4;

            Button btn02 = new Button();
            btn02.VerticalAlignment = VerticalAlignment.Center;
            btn02.HorizontalAlignment = HorizontalAlignment.Center;          
            btn02.Content = img01;

            Content = btn02; //必须要将按钮设置给窗体的Content属性，否则不会显示

        }

    }



    /// <summary>
    /// 3-命令绑定到按钮的操作
    /// </summary>
    class CommandBindBtn:Window
    {
        public CommandBindBtn()
        {
            Title = "Bind the Command on the Button03";

            Button btn03 = new Button();
            btn03.VerticalAlignment = VerticalAlignment.Center;
            btn03.HorizontalAlignment = HorizontalAlignment.Center;
            btn03.FontSize = 30;

            btn03.Command = ApplicationCommands.Paste; //将粘贴命令绑定到按钮的 Command属性上
            btn03.Content = ApplicationCommands.Paste.Text; //设定按钮的内容命令的文本
            Content = btn03;

            //创建新的命令cmdBind 并绑定到对应的事件处理器上
            CommandBinding cmdBind = new CommandBinding(ApplicationCommands.Paste, ExecutePase, CanExecutePaste);
            CommandBindings.Add(cmdBind);

        }

        private void CanExecutePaste(object sender, CanExecuteRoutedEventArgs e)
        {
            //设定当粘贴板上包含内容为文本时，才可以进行粘贴操作，否则按钮为灰色无法进行粘贴操作。
            e.CanExecute = Clipboard.ContainsText();
        }

        private void ExecutePase(object sender, ExecutedRoutedEventArgs e)
        {
            // 将粘贴板板上的文本内容复制给窗口的标题。
            Title = Clipboard.GetText();
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            //只要点击窗体的任何地方，标题都会被重新设定为如下内容
            base.OnMouseDown(e);
            Title= "Bind the Command on the Button03";
        }
    }

    /// <summary>
    /// 4-切换按钮控件
    /// </summary>
    class ToggleTheButton : Window
    {
        public ToggleTheButton()
        {
            Title = "The Toggle Button";

            CheckBox tgBtn = new CheckBox();
            tgBtn.VerticalAlignment = VerticalAlignment.Center;
            tgBtn.HorizontalAlignment = HorizontalAlignment.Center;
            tgBtn.Content = "Hello This Toggle";
            tgBtn.Checked += RespondChose;
            tgBtn.Unchecked += RespondChose;
            tgBtn.IsChecked = (ResizeMode == ResizeMode.CanResize);

            Content = tgBtn;


        }

        private void RespondChose(object sender, RoutedEventArgs e)
        {
            CheckBox tb = sender as CheckBox;
            ResizeMode = (bool)tb.IsChecked ? ResizeMode.CanResize : ResizeMode.NoResize;
        }
    }

    /// <summary>
    /// 5-输入网址导航到指定网页
    /// </summary>
    class UriDialog:Window
    {
        TextBox txtBox;
        public UriDialog()
        {
            Title = "Enter a Uri";
            ShowInTaskbar = false;
            SizeToContent = SizeToContent.WidthAndHeight;
            WindowStyle = WindowStyle.ToolWindow;//设置对话框可以被缩放，但是无最大最小化
            WindowStartupLocation = WindowStartupLocation.CenterOwner; //窗口加载后的起始位置

            txtBox = new TextBox();
            txtBox.Margin = new Thickness(50);
            Content = txtBox;

            txtBox.Focus();
        }

        public string Text
        {
            set
            {
                txtBox.Text = value;
                txtBox.SelectionStart = txtBox.Text.Length;//让光标定位在最后一个字符之后
            }
            get
            {
                return txtBox.Text;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.Key==Key.Enter)
            {
                Close();
            }
        }


    }

    class UseUriDialogNavigate:Window
    {
        Frame frm;
        public UseUriDialogNavigate()
        {
            Title = "Navigate to the Website";
            frm = new Frame(); //让导航的网页在Frame对象中来显示
            Content = frm;

            Loaded += NavigationWinLoad;
        }

        private void NavigationWinLoad(object sender, RoutedEventArgs e)
        {
            UriDialog uriDialog = new UriDialog();
            uriDialog.Text = "https://";
            uriDialog.ShowDialog();

            try
            {
                frm.Source = new Uri(uriDialog.Text);//将对话框中网址赋给Frame对象来进行加载显示
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, Title);
            }
        }
    }
}
