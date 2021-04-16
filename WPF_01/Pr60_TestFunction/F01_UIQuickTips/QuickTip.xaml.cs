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

namespace Pr60_TestFunction.F01_UIQuickTips
{
    public delegate void NextStepDelegate();

    /// <summary>
    /// Interaction logic for QuickTip.xaml
    /// </summary>
    public partial class QuickTip : UserControl
    {
        public event NextStepDelegate NextStepEvent;

        public QuickTip(string stepNum,string discribleText,Visibility vis)
        {
            InitializeComponent();
            

            tbStep.Text = stepNum;
            tbDiscrible.Text = discribleText;
            btnNext.Visibility = vis;
            if (vis==Visibility.Visible)
            {
                btnClose.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnClose.Visibility = Visibility.Visible;
            }
            
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //点击下一步之后，就同时触发该事件来发布消息
            NextStepEvent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
