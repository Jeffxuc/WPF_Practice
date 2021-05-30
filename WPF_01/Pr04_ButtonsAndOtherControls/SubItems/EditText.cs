using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using System.Media;
using System.ComponentModel;

namespace Pr04_ButtonsAndOtherControls.SubItems
{
    class EditText:Window
    {
        string strPath01 = @"D:\WSpace\FileData\WPFData\Pr04_EditText.txt";
        TextBox textBox;

        public EditText()
        {
            Title = "Edit the Text";

            textBox = new TextBox();
            textBox.AcceptsReturn = true; //没有该属性，则按Enter键无反应
            textBox.TextWrapping = TextWrapping.Wrap;
            textBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto; //根据窗口中内容的多少来自动决定是否需要显示滚动条
            textBox.KeyDown += KeyDownOnTextBox;
            Content = textBox;

            //textBox.Text = File.ReadAllText(strPath01);
            //textBox.Focus();
            //textBox.CaretIndex = textBox.Text.Length; //设置光标的位置
            
        }

        private void KeyDownOnTextBox(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.F1) //当按下F1时，插入当前时间
            {
                textBox.SelectedText = DateTime.Now.ToString();
                textBox.CaretIndex = textBox.SelectionStart + textBox.SelectedText.Length;//插入时间后，光标移动到最后面
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //当关闭的时候将内容保存下来
            File.WriteAllText(strPath01,textBox.Text);
        }
    }
}
