using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Ink;

namespace Pr22_WinPageNavigation.Item1_YellowPad
{
    public partial class YellowPadWindow : Window
    {
        void NewOnExecuted(object sender, ExecutedRoutedEventArgs args)
        {
            inkCav.Strokes.Clear();
        }

        void OpenOnExecuted(object sender, ExecutedRoutedEventArgs args)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "Ink Serialized Format(*.isf)|*.isf" + "All files(*.*)|*.*";
            if((bool)dlg.ShowDialog(this))
            {
                try
                {
                    FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    inkCav.Strokes = new StrokeCollection(fileStream);
                    fileStream.Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, Title);
                }
            }
        }

        void SaveOnExcuted(object sender, ExecutedRoutedEventArgs args)
        {

        }
    }
}
