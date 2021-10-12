using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Pr60_TestFunction.F05_ToolTips
{

    /// <summary>
    /// 当文字被截断时，放上鼠标会显示内容
    /// </summary>
    public class convertVal : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }

            bool isTrim = false;

            if (value.GetType() == typeof(Button))
            {
                Button btn = (Button)value;
                isTrim = IsTextTrimmed(btn);
            }
            else if (value.GetType() == typeof(TextBlock))
            {
                TextBlock txtblk = (TextBlock)value;
                isTrim = IsTextTrimmed(txtblk);
            }

            if (isTrim)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        /// <summary>
        /// 判斷當前顯示的內容是否顯示不全被截斷
        /// </summary>
        /// <param name="Button"></param>
        /// <returns></returns>
        private bool IsTextTrimmed(Button btn)
        {
            Typeface typeface = new Typeface(
                btn.FontFamily,
                btn.FontStyle,
                btn.FontWeight,
                btn.FontStretch);

            FormattedText formattedText = new FormattedText(
                btn.Content as string,
                System.Threading.Thread.CurrentThread.CurrentCulture,
                btn.FlowDirection,
                typeface,
                btn.FontSize,
                btn.Foreground);
            bool isTrimmed = formattedText.Width > (btn.ActualWidth - btn.Padding.Left - btn.Padding.Right);
            return isTrimmed;
        }

        private bool IsTextTrimmed(TextBlock txtblk)
        {
            Typeface typeface = new Typeface(
               txtblk.FontFamily,
               txtblk.FontStyle,
               txtblk.FontWeight,
               txtblk.FontStretch);

            FormattedText formattedText = new FormattedText(
                txtblk.Text,
                System.Threading.Thread.CurrentThread.CurrentCulture,
                txtblk.FlowDirection,
                typeface,
                txtblk.FontSize,
                txtblk.Foreground);
            bool isTrimmed = formattedText.Width > (txtblk.ActualWidth - txtblk.Padding.Left - txtblk.Padding.Right);
            return isTrimmed;
        }
    }
}
