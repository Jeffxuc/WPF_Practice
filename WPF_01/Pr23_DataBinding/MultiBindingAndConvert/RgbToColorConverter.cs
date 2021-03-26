using System;
using System.Windows;
using System.Windows.Media;
using System.Globalization;
using System.Windows.Data;

/// <summary>
/// 多重转换接口的实现
/// </summary>
namespace Pr23_DataBinding.MultiBindingAndConvert
{
    // RGB值和对应color之间的转换
    public class RgbToColorConverter : IMultiValueConverter
    {
        // 从RGB值到对应Color的转换
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Color clr = Color.FromRgb((byte)(double)values[0], (byte)(double)values[1], (byte)(double)values[2]);
            if (targetType == typeof(Color))
                return clr;
            if (targetType == typeof(Brush))
                return new SolidColorBrush(clr);

            return null;
        }

        // 从Color到RGB值的转换
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color clr;
            object[] arr = new object[3];
            if (value is Color)
                clr = (Color)value;
            else if (value is Brush)
                clr = (value as SolidColorBrush).Color;
            else
                return null;

            arr[0] = clr.R;
            arr[1] = clr.G;
            arr[2] = clr.B;

            return arr;
            
        }
    }
}
