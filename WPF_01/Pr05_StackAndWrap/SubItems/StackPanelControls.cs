using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace Pr05_StackAndWrap
{
    /// <summary>
    /// 一个StackPanel
    /// </summary>
    class StackPanelControls : Window
    {
        public StackPanelControls()
        {
            Title = "Stack Panel for Button";
            Color clr = Color.FromRgb(200, 100, 180);
            SolidColorBrush brush = new SolidColorBrush(clr);
            Background = brush;

            StackPanel stackPanel = new StackPanel();
            stackPanel.Background = Brushes.AliceBlue;
            Content = stackPanel;
            stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
            stackPanel.Margin = new Thickness(5);

            //stackPanel.Orientation = Orientation.Horizontal; //默认是竖直布局

            Random random = new Random();
            for(int i=0;i<10;++i)
            {
                Button btn = new Button();
                btn.Name = ((char)('A' + i)).ToString();
                btn.FontSize = random.Next(15,30);
                btn.Content = "Button " + btn.Name + "  just Click me";
                btn.Click += ClickTheBtn;
                btn.Margin = new Thickness(10);

                //btn.HorizontalAlignment = HorizontalAlignment.Center;
                stackPanel.Children.Add(btn);
                
            }         
        }

        private void ClickTheBtn(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;//由于以上将事件处理器直接注册到Click事件上，所以可以用sender来获取触发事件的对象。
            MessageBox.Show(btn.Name + " has been clicked");
        }
    }

    /// <summary>
    /// 一个StackPanel中嵌套多个StackPanel
    /// </summary>
    class StackPanelWithFour:Window
    {
        public StackPanelWithFour()
        {
            Title = "Four stack panel";
            SizeToContent = SizeToContent.WidthAndHeight; //让窗口尺寸适应内容

            StackPanel stackPanelMain = new StackPanel();
            Content = stackPanelMain;
            stackPanelMain.Orientation = Orientation.Horizontal;
            stackPanelMain.Margin = new Thickness(20);
            //添加事件处理器
            stackPanelMain.AddHandler(Button.ClickEvent, new RoutedEventHandler(RespondBtnClick));

            for(int i=0;i<3;++i)
            {
                StackPanel sp = new StackPanel();
                stackPanelMain.Children.Add(sp);

                for(int j=0;j<10;++j)
                {
                    Button btn = new Button();
                    string strName = "StackPanel_" + i+"_Button_" + j;
                    btn.Name = strName;
                    btn.FontSize = 18;
                    btn.Content = btn.Name + " : Click me";
                    btn.Margin = new Thickness(4);
                    sp.Children.Add(btn);
                }

            }

        }

        private void RespondBtnClick(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button; //e.Source为触发该事件的对象的引用
            //Button btn = sender as Button;//由于未将对象绑定在具体实例上，因此该方式将不能获取具体是哪个Button触发了事件
            MessageBox.Show(btn.Name + " has clicked me!");
        }
    }

    class DesignAButton :Window
    {
        public DesignAButton()
        {
            Title = "Design a Button";

            Button btn = new Button();
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.Click += BtnClick;
            Content = btn;

            StackPanel sp = new StackPanel();
            btn.Content = sp;
            sp.Children.Add(Zigzag(10));            

            Uri uri = new Uri("D:\\Temp\\img03.jpeg");
            BitmapImage bitmap = new BitmapImage(uri);
            Image img = new Image();
            img.Margin = new Thickness(10, 10, 10, 20);
            img.Stretch = Stretch.None;
            img.Source = bitmap;
            sp.Children.Add(img);

            Label lb = new Label();
            lb.Content = "_ReadBook";
            lb.HorizontalContentAlignment = HorizontalAlignment.Center;
            sp.Children.Add(lb);


            sp.Children.Add(Zigzag(0));



        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button has been clicked", Title);
        }

        private Polyline Zigzag(int offset)
        {
            Polyline polyline = new Polyline();
            polyline.Stroke = SystemColors.ControlTextBrush;
            polyline.Points = new PointCollection();
            for(int i=0;i<=360;i+=10)
            {
                polyline.Points.Add(new Point(i, (i + offset) % 20));
            }
            return polyline;
        }
    }

    class TuneTheBtn:Window
    {
        public TuneTheBtn()
        {
            Title = "Tune the Radio";
            SizeToContent = SizeToContent.WidthAndHeight;

            GroupBox groupBox = new GroupBox();
            groupBox.Header = "Change the Windows Style";
            groupBox.Margin = new Thickness(96);
            groupBox.Padding = new Thickness(6);
            Content = groupBox;
            
            StackPanel stackPanel = new StackPanel();
            groupBox.Content = stackPanel;
            
            stackPanel.Children.Add(CreateRadioBtn("A window with No border or caption", WindowStyle.None));
            stackPanel.Children.Add(CreateRadioBtn("A window with a single border", WindowStyle.SingleBorderWindow));
            stackPanel.Children.Add(CreateRadioBtn("A window with a 3-D border", WindowStyle.ThreeDBorderWindow));
            stackPanel.Children.Add(CreateRadioBtn("A fixed tool window", WindowStyle.ToolWindow));

            stackPanel.AddHandler(RadioButton.ClickEvent, new RoutedEventHandler(RadioBtnClicked));

        }

        private RadioButton CreateRadioBtn(string str,WindowStyle windowStyle)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Content = str;
            radioButton.Tag = windowStyle;
            radioButton.Margin = new Thickness(10);
            radioButton.IsChecked = (windowStyle == WindowStyle); //判断该按钮是否被选中
            return radioButton;
        }

        void RadioBtnClicked(object sender,RoutedEventArgs e)
        {
            RadioButton radioButton = e.Source as RadioButton;
            WindowStyle = (WindowStyle)radioButton.Tag;
        }
    }


    /// <summary>
    /// the use of WrapPanel
    /// </summary>
    class ExploreDirectories:Window
    {
        public ExploreDirectories()
        {
            Title = "Explore the directories";

            ScrollViewer scroll = new ScrollViewer();
            Content = scroll;

            WrapPanel wrapPanel = new WrapPanel();
            scroll.Content = wrapPanel;

            wrapPanel.Children.Add(new FileSystemInfoButton());
        }

    }

    class FileSystemInfoButton:Button
    {
        FileSystemInfo fileInfo;

        public FileSystemInfoButton() : this(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))
        {

        }
        public FileSystemInfoButton(FileSystemInfo info)
        {
            fileInfo = info;
            Content = fileInfo.Name;
            if(fileInfo is DirectoryInfo)
            {
                FontWeight = FontWeights.Bold;
            }
            Margin = new Thickness(10);
        }
        public FileSystemInfoButton(FileSystemInfo info,string str):this(info)
        {
            Content = str;
        }

        protected override void OnClick()
        {
            if(fileInfo is FileInfo)
            {
                Process.Start(fileInfo.FullName);
            }
            else if(fileInfo is DirectoryInfo)
            {
                DirectoryInfo dir = fileInfo as DirectoryInfo;
                Application.Current.MainWindow.Title = dir.FullName;
                Panel panel = Parent as Panel;
                panel.Children.Clear();
                if(dir.Parent!=null)
                {
                    panel.Children.Add(new FileSystemInfoButton(dir.Parent, ".."));
                }

                foreach(var i in dir.GetFileSystemInfos())
                {
                    panel.Children.Add(new FileSystemInfoButton(i));
                }
            }
        }
    }

}
