using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

/// <summary>
/// 实现double类型到byte类型的转换
/// </summary>
namespace Pr23_DataBinding.MultiBindingAndConvert
{
    [ValueConversion(typeof(double), typeof(byte))]
    public class DoubleToByteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //在此必须要先将value转换成double类型，再转换成byte类型，直接转换成byte类型会报错
            return (byte)(double)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value;

            //很多时候都用不上，可以不用写，直接返回空
            //return null;
        }
    }
}
