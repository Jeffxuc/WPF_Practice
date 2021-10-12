using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pr60_TestFunction.F06_AlignEvenly
{
    /// <summary>
    /// Interaction logic for AlignEvenly.xaml
    /// </summary>
    public partial class AlignEvenly : Window
    {
        bool isTrim = false;
        int lineNum = 1;

        public AlignEvenly()
        {
            InitializeComponent();


            //inputTxt.TextChanged += TextInShow;
            inputTxt.TextChanged += DisplayText;

            for(int i=0; i<alignSP.Children.Count; ++i)
            {
                Button btn = alignSP.Children[i] as Button;
                btn.Click += AlignBtn;
            }

            for(int j=0; j<cards.Children.Count; ++j)
            {
                Button btn = cards.Children[j] as Button;
                btn.Click += SelectCard;
            }

            

        }

        private void SelectCard(object sender, RoutedEventArgs e)
        {
            Button curBtn = sender as Button;
            inputTxt.Text += curBtn.Content.ToString();
        }

        private void AlignBtn(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "leftBtn":
                    showTxt.TextAlignment = TextAlignment.Left;
                    break;
                case "centerBtn":
                    showTxt.TextAlignment = TextAlignment.Center;
                    break;
                case "rightBtn":
                    showTxt.TextAlignment = TextAlignment.Right;
                    break;
                case "evenlyBtn":
                    //showTxt.TextAlignment = TextAlignment.Justify;
                    test.TextTrimming = TextTrimming.CharacterEllipsis;
                    test.TextWrapping = TextWrapping.NoWrap;
                    break;
            }
        }

        private void TextInShow(object sender, TextChangedEventArgs e)
        {
            //Regex regex = new Regex("[\t\r\n]");
            //string replaceStr = regex.Replace(inputTxt.Text, "");
            string tmpStr = inputTxt.Text;

            showTxt.Text = inputTxt.Text;
            //test.Text = inputTxt.Text;

            isTrim = IsTextTrimmed(showTxt);

            if (isTrim && lineNum == 1)
            {
                showTxt.FontSize = 22;
                showTxt.Margin = new Thickness(17, 11,17,11);

            }

            if(showTxt.FontSize==22 && isTrim)
            {
                lineNum = 2;
                
            }

            if (lineNum == 2 && IsTextTrimmed(showTxt,2))
            {
                //inputTxt.IsEnabled = false;
                //inputTxt.Opacity = 0.4;
            }

        }

        private void DisplayText(object sender, TextChangedEventArgs e)
        {
            tmpBox.Text = inputTxt.Text;
            showTxt.Text = inputTxt.Text;

            if (IsTextTrimmed(showTxt))
            {
                showTxt.FontSize = 22;
                showTxt.Margin = new Thickness(17, 11, 17, 11);
            }

            if(tmpBox.LineCount == 2)
            {
                int line = tmpBox.LineCount;
            }









        }



        private void TextAlignEvenly()
        {

        }

        private bool IsTextTrimmed(TextBlock txtblk, int num=1)
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
            bool isTrimmed = formattedText.Width > num*(txtblk.ActualWidth - txtblk.Padding.Left - txtblk.Padding.Right);
            return isTrimmed;
        }



    }
}
