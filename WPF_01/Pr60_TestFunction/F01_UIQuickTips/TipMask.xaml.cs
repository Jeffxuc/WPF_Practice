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
    /// <summary>
    /// Interaction logic for TipMask.xaml
    /// </summary>
    public partial class TipMask : Window
    {
        PathGeometry pathGeometry = new PathGeometry();
        List<QuickTipData> list;
        int index = 0;
        
        public TipMask(Window win,List<QuickTipData>ls)
        {
            InitializeComponent();

            Width = win.ActualWidth-12;
            Height = win.ActualHeight-6;
            Top = win.Top;
            Left = win.Left+6;
            Owner = win;
            list = ls;

            ShowTips(index, list[index].UIContent, list[index].UITip, Visibility.Visible);
        }

        private void ShowTips(int num,string textContent,FrameworkElement controlElement,Visibility vis)
        {
            //获取控件坐标点
            Point controlPos = controlElement.TransformToAncestor(GetWindow(controlElement)).Transform(new Point(0, 0));

            RectangleGeometry rectPos = new RectangleGeometry();
            rectPos.Rect = new Rect(0, 0, this.Width, this.Height);
            pathGeometry = Geometry.Combine(pathGeometry, rectPos, GeometryCombineMode.Union, null);
            boder.Clip = pathGeometry;

            RectangleGeometry rectControl = new RectangleGeometry();
            rectControl.Rect = new Rect(controlPos.X+1, controlPos.Y+9+ controlElement.ActualHeight, controlElement.ActualWidth-1, controlElement.ActualHeight);
            pathGeometry = Geometry.Combine(pathGeometry, rectControl, GeometryCombineMode.Exclude, null);
            boder.Clip = pathGeometry;

            QuickTip quickTip = new QuickTip("Step "+(++num).ToString(),textContent,vis);
            Canvas.SetLeft(quickTip, controlPos.X + controlElement.ActualWidth);
            Canvas.SetTop(quickTip, controlPos.Y + controlElement.ActualHeight+40);
            canv.Children.Add(quickTip);

            quickTip.NextStepEvent += OnNextStep;

            index++;
        }

        private void OnNextStep()
        {
            if(index<list.Count && list[index]!=null)
            {
                canv.Children.Clear();
            }
            if(index==list.Count-1)
            {
                ShowTips(index, list[index].UIContent, list[index].UITip,Visibility.Collapsed);
            }
            else
            {
                ShowTips(index, list[index].UIContent, list[index].UITip, Visibility.Visible);
            }

        }

    }
}
