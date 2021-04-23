using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

/// <summary>
/// 自定义 SelfDateTimeProperty，通过SelfDateTime来对其进行暴露
/// </summary>
namespace Pr23_DataBinding.DigitalClock
{
    class ClockTicker1:DependencyObject
    {
        //在此自定义了依赖属性
        public static DependencyProperty SelfDateTimeProperty = 
            DependencyProperty.Register("SelfDateTime", typeof(DateTime), typeof(ClockTicker1));

        // SelfDateTimeProperty是其属性
        public DateTime SelfDateTime
        {
            set { SetValue(SelfDateTimeProperty, value); }
            get { return (DateTime)GetValue(SelfDateTimeProperty); }
        }

        public ClockTicker1()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimeOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void TimeOnTick(object sender, EventArgs e)
        {
            SelfDateTime = DateTime.Now;
        }
    }
}
