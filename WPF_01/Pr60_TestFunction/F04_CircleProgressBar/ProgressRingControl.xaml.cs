using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Expression.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pr60_TestFunction.F04_CircleProgressBar
{
    /// <summary>
    /// ProgressRingControl.xaml 的互動邏輯
    /// </summary>
    public partial class ProgressRingControl : UserControl, INotifyPropertyChanged
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        BitmapImage bitImg;
        BitmapImage bitImg2;
        public ProgressRingControl()
        {
            // !!!! 必须要先将当前的数据赋给 DataContext，否则无法得到对应类中的属性值。
            DataContext = this;

            bitImg = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F04_CircleProgressBar/Images/play-preview-select@3x.png"));
            bitImg2 = new BitmapImage(new Uri("pack://application:,,,/Pr60_TestFunction;component/F04_CircleProgressBar/Images/play-preview-normal@3x.png"));
            ImgUri = bitImg2;

            Num = 0;
            InitializeComponent();

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChangedNotify([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private BitmapImage imgUri;
        public BitmapImage ImgUri
        {
            get { return imgUri; }
            set
            {
                if(imgUri != value)
                {
                    imgUri = value;
                    //PropertyChangedNotify();
                }
            }
        }

        private int num=0;
        public int Num
        {
            get { return num; }
            set
            {
                if(num!=value && value<=360)
                {
                    num = value;
                    PropertyChangedNotify();
                }
            }
        }
    }
}
