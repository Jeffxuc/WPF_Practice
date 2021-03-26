using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
using System.Windows.Input;
using Microsoft.Win32;
using System.Windows.Documents;

namespace Pr04_ButtonsAndOtherControls.SubItems
{
    class EditRichText:Window
    {
        RichTextBox richTextBox;
        string strFilter = "Document Files(*.xml)|*.xaml|All files(*.*)|*.*";

        public EditRichText()
        {
            Title = "Edit some rich text";

            richTextBox = new RichTextBox();
            richTextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            richTextBox.Focus();
            Content = richTextBox;

        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            if(e.ControlText.Length>0 && e.ControlText[0]=='\x0F')
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.CheckFileExists = true;
                dlg.Filter = strFilter;
                if((bool)dlg.ShowDialog(this))
                {
                    FlowDocument flowDocument = richTextBox.Document;
                    TextRange textRange = new TextRange(flowDocument.ContentStart, flowDocument.ContentEnd);
                    Stream strm = null;

                    try
                    {
                        strm = new FileStream(dlg.FileName, FileMode.Open);
                    }
                    catch
                    {

                    }

                }

            }


        }


    }
}
