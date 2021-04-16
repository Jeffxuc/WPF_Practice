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
using Pr60_TestFunction.F01_UIQuickTips;

namespace Pr60_TestFunction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //存放需要引导进行QuickTips的控件
        List<QuickTipData> list = new List<QuickTipData>();
        public MainWindow()
        {
            InitializeComponent();

            list.Add(new QuickTipData(btn01, "This is Button 01"));
            list.Add(new QuickTipData(btn02, "This is Button 02"));
            list.Add(new QuickTipData(btn03, "This is Button 03"));
            list.Add(new QuickTipData(btn04, "This is Button 04"));           
        }

        private void GetControlPos(FrameworkElement fe)
        {
            GeneralTransform generalTransform1 = myTextBlock.TransformToAncestor(this);
            Point currentPoint = generalTransform1.Transform(new Point(0, 0));

        }

        /// <summary>
        /// 主页面加载的时候，就显示遮罩和QuickTips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wind_Loaded(object sender, RoutedEventArgs e)
        {
            TipMask tipMask = new TipMask(this, list);
            tipMask.Show();
        }

        /// <summary>
        /// 点击帮助按钮，再次显示Quick Tips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TipMask tipMask = new TipMask(this, list);
            tipMask.Show();
        }
    }
}
