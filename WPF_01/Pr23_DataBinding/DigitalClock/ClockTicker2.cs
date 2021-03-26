using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

/// <summary>
/// 另一种方式来实现自定义属性SelfDateTime的改变通知
/// </summary>
namespace Pr23_DataBinding.DigitalClock
{
    public class ClockTicker2:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // 自定义的属性：SelfDateTime
        public DateTime SelfDateTime
        {
            get { return DateTime.Now; }
        }

        public ClockTicker2()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimeOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void TimeOnTick(object sender, EventArgs e)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("SelfDateTime"));
            }
        }
    }
}
