using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace Pr06_DockAndGrid
{
    class Docker: Window
    {
        public Docker()
        {
            Title = "Dock_01";
            DockPanel dock = new DockPanel();
            Content = dock;

            for(int i=0;i<17;++i)
            {
                Button btn = new Button();
                btn.Content = "Button Num " + i;
                dock.Children.Add(btn);
                btn.SetValue(DockPanel.DockProperty, (Dock)(i%4));//设置按钮的停泊位置,位置的值必须要显示转换成Dock类型。
                
            }

            dock.LastChildFill = false;

        }

    }

    class MeetTheDocker:Window
    {
        
        public MeetTheDocker()
        {
            Title = "Meet the docker";

            //将DockPanel赋给窗口
            DockPanel dockPanel = new DockPanel();
            Content = dockPanel;

            //创建菜单栏，并将其dock到窗口上面
            Menu menu = new Menu();
            MenuItem item = new MenuItem();
            item.Header = "The Menu";
            menu.Items.Add(item);
            dockPanel.Children.Add(menu);
            DockPanel.SetDock(menu, Dock.Top);

            //创建工具栏
            ToolBar toolBar = new ToolBar();
            toolBar.Header = "Creat a toolBar";
            dockPanel.Children.Add(toolBar);
            DockPanel.SetDock(toolBar, Dock.Top);

            //创建状态栏，并添加状态栏条目。将状态栏停泊到窗口底部
            StatusBar statusBar = new StatusBar();
            StatusBarItem statusBarItem = new StatusBarItem();
            statusBarItem.Content = "status Bar";
            statusBar.Items.Add(statusBarItem);
            dockPanel.Children.Add(statusBar);
            DockPanel.SetDock(statusBar, Dock.Bottom);

            //创建列表栏，
            ListBox listBox = new ListBox();
            listBox.Items.Add("List Box Item");
            dockPanel.Children.Add(listBox);
            DockPanel.SetDock(listBox, Dock.Left);

            

            //让中间部分为文本框
            TextBox textBox = new TextBox();
            textBox.AcceptsReturn = true;
            dockPanel.Children.Add(textBox);
            textBox.Focus();
        }
    }


    /// <summary>
    /// Grid 的使用
    /// </summary>
    class UseGrid:Window
    {
        public UseGrid()
        {
            Title = "The use of Grid";

            Grid grid = new Grid();
            Content = grid;
            SizeToContent = SizeToContent.WidthAndHeight;

            //生成3行4列的网格
            for(int i=0;i<3;++i)
            {
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(100);
                grid.RowDefinitions.Add(rowDefinition);
            }
            for(int j=0;j<4;++j)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width = new GridLength(60);
                grid.ColumnDefinitions.Add(columnDefinition);
            }

            grid.ShowGridLines = true;

            grid.Margin = new Thickness(10);
            grid.Background = Brushes.BlueViolet;

            Button btn01 = new Button();
            btn01.Content = "Button01";
            grid.Children.Add(btn01);
            Grid.SetRow(btn01, 1);
            Grid.SetRowSpan(btn01, 2);
            Grid.SetColumn(btn01, 2);
            Grid.SetColumnSpan(btn01, 2);

            btn01.Margin = new Thickness(5);
        }
    }

    /// <summary>
    /// 计算年龄的程序
    /// </summary>
    class CalculateYourLife:Window
    {
        TextBox textBoxBegin, textBoxEnd;
        Label labRes;
        public CalculateYourLife()
        {
            Title = "Calculate Your Life";
            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.CanResize;

            // 生成三行两列的 Grid
            Grid grid = new Grid();
            Content = grid;
            for(int i=0;i<3;++i)
            {
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = GridLength.Auto;
                grid.RowDefinitions.Add(rowDef);
            }

            for(int j=0;j<2;++j)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                colDef.Width = GridLength.Auto;
                grid.ColumnDefinitions.Add(colDef);
            }

            //第(1,1)的标签
            Label lb01 = new Label();
            lb01.Content = "Begin Date: ";
            grid.Children.Add(lb01);
            Grid.SetRow(lb01, 0);
            Grid.SetColumn(lb01, 0);

            //第(1,2)的文本框
            textBoxBegin = new TextBox();
            textBoxBegin.Text = new DateTime(2020, 01, 20).ToShortDateString();
            textBoxBegin.TextChanged += TextBoxOnTextChange;
            grid.Children.Add(textBoxBegin);
            Grid.SetRow(textBoxBegin, 0);
            Grid.SetColumn(textBoxBegin, 1);

            //第(2,1)的标签
            lb01 = new Label();
            lb01.Content = "End Date: ";
            grid.Children.Add(lb01);
            Grid.SetRow(lb01, 1);
            Grid.SetColumn(lb01, 0);

            //第(2,2)的文本框
            textBoxEnd = new TextBox();
            textBoxEnd.Text = DateTime.Now.ToShortDateString();
            textBoxEnd.TextChanged += TextBoxOnTextChange;
            grid.Children.Add(textBoxEnd);
            Grid.SetRow(textBoxEnd, 1);
            Grid.SetColumn(textBoxEnd, 1);

            //第(3,1)的标签
            lb01 = new Label();
            lb01.Content = "Life Years: ";
            grid.Children.Add(lb01);
            Grid.SetRow(lb01,2);
            Grid.SetColumn(lb01, 0);

            //第(3,2)的标签:显示计算结果
            labRes = new Label();

            grid.Children.Add(labRes);
            Grid.SetRow(labRes, 2);
            Grid.SetColumn(labRes, 1);

            Thickness thick = new Thickness(5);
            grid.Margin = thick;
            
            foreach(Control control in grid.Children)
            {
                control.Margin = thick;
            }

            textBoxBegin.Focus();

        }

        private void TextBoxOnTextChange(object sender, TextChangedEventArgs e)
        {
            DateTime dateBegin, dateEnd;
            if(DateTime.TryParse(textBoxBegin.Text, out dateBegin) &&
                DateTime.TryParse(textBoxEnd.Text, out dateEnd))
            {
                int Years = dateEnd.Year - dateBegin.Year;
                int Months = dateEnd.Month - dateBegin.Month;
                int Days = dateEnd.Day - dateBegin.Day;

                if(Days<0)
                {
                    Days += DateTime.DaysInMonth(dateEnd.Year, 1 + (dateEnd.Month + 10) % 12);
                    Months -= 1;
                }
                if(Months<0)
                {
                    Months += 12;
                    Years--;
                }

                // 判断数值是否大于1，若大于1就以复数的形式显示
                labRes.Content = string.Format("{0} year{1}, {2} month{3}, {4} day{5}",
                    Years, Years == 1 ? "" : "s",
                    Months, Months == 1 ? "" : "s",
                    Days, Days == 1 ? "" : "s");
            }
            else
            {
                labRes.Content = "NoRes";
            }
        }
    }


    /// <summary>
    /// the use of GridSplitter
    /// </summary>
    class GridSpliter:Window
    {
        public GridSpliter()
        {
            Title = "Split the grid in 9 part";

            Grid grid = new Grid();
            Content = grid;

            for(int i=0;i<3;i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for(int x=0;x<3;x++)
                for (int y = 0; y < 3; y++)
                {
                    Button btn = new Button();
                    btn.Content = "Row " + x + "," + "Col " + y;
                    btn.Margin = new Thickness(10);
                    grid.Children.Add(btn);
                    Grid.SetRow(btn, x);
                    Grid.SetColumn(btn, y);
                }

            GridSplitter gridSpliter = new GridSplitter();
            gridSpliter.HorizontalAlignment = HorizontalAlignment.Left;
            gridSpliter.Width = 6;
            grid.Children.Add(gridSpliter);
            Grid.SetRow(gridSpliter, 0);
            Grid.SetColumn(gridSpliter, 1);
            Grid.SetRowSpan(gridSpliter, 3);

        }
    }

    /// <summary>
    /// 使用分割条
    /// </summary>
    class UseSpliter:Window
    {
        public UseSpliter()
        {
            Title = "Use the Splitter";
            Grid grid = new Grid();
            Content = grid;

            //主窗口中的grid有3列
            for(int i=0;i<3;++i)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                grid.ColumnDefinitions.Add(colDef);

                if(i==1)
                {
                    colDef.Width = GridLength.Auto;
                }
            }

            //第一列为按钮
            Button btn01 = new Button();
            btn01.Content = "Button_01";
            grid.Children.Add(btn01);
            Grid.SetRow(btn01, 0);
            Grid.SetColumn(btn01, 0);

            // 第二列为分割条
            GridSplitter sp = new GridSplitter();
            sp.ShowsPreview = true; //必须等鼠标松开时，才会改变格子的尺寸
            sp.HorizontalAlignment = HorizontalAlignment.Center;
            sp.VerticalAlignment = VerticalAlignment.Stretch;
            sp.Width = 6;
            grid.Children.Add(sp);
            Grid.SetRow(sp, 0);
            Grid.SetColumn(sp, 1);

            //第三列为子Grid
            Grid grid02 = new Grid();
            for(int i=0;i<3;i++)
            {
                RowDefinition rowDef = new RowDefinition();
                grid02.RowDefinitions.Add(rowDef);
                if(i==1)
                {
                    rowDef.Height = GridLength.Auto;
                }
            }
            grid.Children.Add(grid02);
            Grid.SetRow(grid02, 0);
            Grid.SetColumn(grid02, 2);

            Button btn02 = new Button();
            btn02.Content = "Button_2";
            grid02.Children.Add(btn02);
            Grid.SetRow(btn02, 0);
            Grid.SetColumn(btn02, 0);

            GridSplitter sp02 = new GridSplitter();
            sp02.Height = 6;
            //sp02.ShowsPreview = true;
            sp02.VerticalAlignment = VerticalAlignment.Center;
            sp02.HorizontalAlignment = HorizontalAlignment.Stretch;
            grid02.Children.Add(sp02);
            Grid.SetRow(sp02,1);
            Grid.SetColumn(sp02, 0);

            Button btn03 = new Button();
            btn03.Content = "Button_3";
            grid02.Children.Add(btn03);
            Grid.SetRow(btn03, 2);
            Grid.SetColumn(btn03, 0);
            

        }
    }


    /// <summary>
    /// 通过移动滚动条来改变Panel的颜色
    /// </summary>
    class ScrollColor:Window
    {
        ScrollBar[] scrollBar = new ScrollBar[3];
        TextBlock[] textBlock = new TextBlock[3];
        Panel stp;

        public ScrollColor()
        {
            Title = "Scroll Use";
            Grid gdMain = new Grid();
            Content = gdMain;
            Width = 500;
            Height = 300;

            for(int i=0;i<3;++i)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                if(i==0)
                {
                    colDef.Width = new GridLength(200, GridUnitType.Pixel);
                }
                else if(i==1)
                {
                    colDef.Width = GridLength.Auto;
                }
                else
                {
                    colDef.Width = new GridLength(100, GridUnitType.Star);
                }

                gdMain.ColumnDefinitions.Add(colDef);
            }

            Grid gdSub = new Grid();
            gdMain.Children.Add(gdSub);
            Grid.SetRow(gdSub, 0);
            Grid.SetColumn(gdSub, 0);

            GridSplitter sp = new GridSplitter();
            sp.Width = 6;
            sp.HorizontalAlignment = HorizontalAlignment.Center;
            sp.VerticalAlignment = VerticalAlignment.Stretch;
            gdMain.Children.Add(sp);
            Grid.SetRow(sp, 0);
            Grid.SetColumn(sp, 1);

            stp = new StackPanel();
            stp.Background = new SolidColorBrush(SystemColors.WindowColor);
            gdMain.Children.Add(stp);
            Grid.SetRow(stp, 0);
            Grid.SetColumn(stp, 2);

            for(int i=0;i<3;++i)
            {
                RowDefinition rowDef = new RowDefinition();
                if(i==1)
                {
                    rowDef.Height = new GridLength(100, GridUnitType.Star);          
                }
                else
                {
                    rowDef.Height = GridLength.Auto;
                }

                gdSub.RowDefinitions.Add(rowDef);
            }
            gdSub.ShowGridLines = true;

            for(int i=0;i<3;++i)
            {
                ColumnDefinition columDef = new ColumnDefinition();
                columDef.Width = new GridLength(33, GridUnitType.Star);
                gdSub.ColumnDefinitions.Add(columDef);
            }

            for(int i=0;i<3;++i)
            {
                Label lb = new Label();
                lb.Content = new string[] { "Red", "Green", "Blue" }[i];
                lb.HorizontalAlignment = HorizontalAlignment.Center;
                gdSub.Children.Add(lb);
                Grid.SetRow(lb, 0);
                Grid.SetColumn(lb, i);

                scrollBar[i] = new ScrollBar();
                scrollBar[i].Focusable = true;
                scrollBar[i].Orientation = Orientation.Vertical;
                scrollBar[i].Minimum = 0;
                scrollBar[i].Maximum = 255;
                scrollBar[i].SmallChange = 1;
                scrollBar[i].LargeChange = 16;
                scrollBar[i].ValueChanged += ScrollValueChange;
                gdSub.Children.Add(scrollBar[i]);
                Grid.SetRow(scrollBar[i], 1);
                Grid.SetColumn(scrollBar[i], i);

                textBlock[i] = new TextBlock();
                textBlock[i].TextAlignment = TextAlignment.Center;
                textBlock[i].HorizontalAlignment = HorizontalAlignment.Center;
                textBlock[i].Margin = new Thickness(5);
                gdSub.Children.Add(textBlock[i]);
                Grid.SetRow(textBlock[i], 2);
                Grid.SetColumn(textBlock[i], i);
            }

            Color clr = (stp.Background as SolidColorBrush).Color;
            scrollBar[0].Value = clr.R;
            scrollBar[1].Value = clr.G;
            scrollBar[2].Value = clr.B;

            scrollBar[0].Focus();

        }

        private void ScrollValueChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScrollBar sbr = sender as ScrollBar;
            Panel pl = sbr.Parent as Panel;

            TextBlock txt = pl.Children[1 + pl.Children.IndexOf(sbr)] as TextBlock;

            txt.Text = string.Format("{0}\n0x{0:x2}", (int)sbr.Value);
            stp.Background = new SolidColorBrush(Color.FromRgb((byte)scrollBar[0].Value, (byte)scrollBar[1].Value, (byte)scrollBar[2].Value));
        }
    }

}
