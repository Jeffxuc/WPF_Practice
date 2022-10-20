using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using System.Windows.Data;

/// <summary>
/// 将ScrollBar的值从double类型转换成decimal类型，来进行显示
/// </summary>
namespace Pr23_DataBinding.ConvertValueType
{
    // 对 IValueConverter 接口进行实现，该类设置为公有的，否则在别的文件中不能被访问
    [ValueConversion(typeof(double), typeof(decimal))]
    public class DoubleToDecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //parameter是用来说明保留的小数位数，对应XAML文件中的ConverterParameter值
            decimal num = new decimal((double)value);
            if(parameter!=null)
            {
                num = Decimal.Round(num, Int32.Parse(parameter as string));
            }
            return num;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Decimal.ToDouble((decimal)value);
        }
    }


    /// <summary>
    /// When "BorderThickness=0",  return Collapsed, otherwise return Visible.
    /// </summary>
    [ValueConversion(typeof(Thickness), typeof(Visibility))]
    public class Thickness2Visible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Thickness thickness = new Thickness(0);
            Thickness res = (Thickness)value;

            if (res==thickness)
            {
                return Visibility.Collapsed;
            }
            else
                return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility vis = (Visibility)value;
            if (vis == Visibility.Visible)
            {
                return new Thickness(1);
            }
            else
                return new Thickness(0);

            
        }
    }
}
