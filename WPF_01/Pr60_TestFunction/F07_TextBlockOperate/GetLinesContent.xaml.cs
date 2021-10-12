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

namespace Pr60_TestFunction.F07_TextBlockOperate
{
    /// <summary>
    /// Interaction logic for GetLinesContent.xaml
    /// </summary>
    public partial class GetLinesContent : Window
    {
        public GetLinesContent()
        {
            InitializeComponent();

            for (int j = 0; j < cards.Children.Count; ++j)
            {
                Button btn = cards.Children[j] as Button;
                btn.Click += SelectCard;
            }

            inputBox.TextChanged += InputTxt;
        }

        private void SelectCard(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            inputBox.Text += btn.Content;

        }

        private void InputTxt(object sender, TextChangedEventArgs e)
        {
            string strTmp = inputBox.Text;
            preTxt.Text = strTmp;
            inputNum.Text = inputBox.Text.Length.ToString();
            showNum.Text = preTxt.Text.Length.ToString();


            if (IsTextTrimmed(preTxt))
            {
                preTxt.FontSize = 22;
                preTxt.Margin = new Thickness(17, 12, 17, 12);
            }

           if(IsTextTrimmed(preTxt))
            {
                IEnumerable<string> var = TextUtils.GetLines(preTxt);
                int lineCount = var.Count<string>();

                if(lineCount > 2/*IsTextTrimmed(preTxt,2)*/)
                {
                    string str1 = var.ElementAt<string>(0);
                    string str2 = var.ElementAt<string>(1);

                    int maxNum = str1.Length + str2.Length;
                    inputBox.MaxLength = maxNum;
                    preTxt.Text = str1 + str2;
                    wordNumTip.Visibility = Visibility.Visible;
                    cards.IsEnabled = false;


                }
                else
                {
                    wordNumTip.Visibility = Visibility.Collapsed;
                }

            }

        }

        private bool IsTextTrimmed(TextBlock txtblk, int num = 1)
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
            bool isTrimmed = formattedText.Width > num * (txtblk.ActualWidth - txtblk.Padding.Left - txtblk.Padding.Right);
            return isTrimmed;
        }

        private void TmpBtn_Click(object sender, RoutedEventArgs e)
        {
            if(cards.Visibility==Visibility.Visible)
            {
                cards.Visibility = Visibility.Collapsed;
            }
            else
            {
                cards.Visibility = Visibility.Visible;
            }
        }
    }


    public static class TextUtils
    {
        public static IEnumerable<string> GetLines(this TextBlock source)
        {
            var text = source.Text;
            int offset = 0;
            TextPointer lineStart = source.ContentStart.GetPositionAtOffset(1, LogicalDirection.Forward);
            do
            {
                TextPointer lineEnd = lineStart != null ? lineStart.GetLineStartPosition(1) : null;
                int length = lineEnd != null ? lineStart.GetOffsetToPosition(lineEnd) : text.Length - offset;
                yield return text.Substring(offset, length);
                offset += length;
                lineStart = lineEnd;
            }
            while (lineStart != null);
        }
    }

}
