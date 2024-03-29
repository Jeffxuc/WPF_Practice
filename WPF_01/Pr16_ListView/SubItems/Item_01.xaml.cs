﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr16_ListView.SubItems
{
    /// <summary>
    /// Interaction logic for Item_01.xaml
    /// </summary>
    public partial class Item_01 : UserControl
    {
        public Item_01()
        {
            InitializeComponent();

            item00.Items.Add("add a new item.");
            Rectangle rec = new Rectangle();
            rec.Width = 50;
            rec.Height = 30;
            rec.Fill = Brushes.BlueViolet;
            item00.Items.Add(rec);

        }



        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter || e.Key==Key.Space)
            {
                ListViewItem listViewItem = sender as ListViewItem;
                Button btn = listViewItem.Content as Button;
                SelectBtn(btn);
            }

            //e.Handled = true;
        }

        private void Grid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                ListViewItem listViewItem = sender as ListViewItem;
                Button btn = listViewItem.Content as Button;
                SelectBtn(btn);
            }
        }

        private void Grid_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                ListViewItem listViewItem = sender as ListViewItem;
                Button btn = listViewItem.Content as Button;
                SelectBtn(btn);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SelectBtn(btn);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SelectBtn(btn);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SelectBtn(btn);
        }

        private void SelectBtn(Button btn)
        {
            btn.Foreground = Brushes.Red;
        }

        /// <summary>
        /// ListView中下一行的元素不能通过 arrow right 键直接来遍历。
        /// 设置arrow Left/Right 键可以遍历整个ListView中的不同行所有元素，
        /// 可以在行首或行尾自动跳到下一行或者上一行。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item32_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Right)
            {
                e.Handled = true;

                if (item32.SelectedIndex < item32.Items.Count-1)
                {
                    item32.SelectedIndex++;
                    (item32.Items[item32.SelectedIndex] as ListViewItem).Focus();
                }

            }
            else if(e.Key == Key.Left)
            {
                e.Handled = true;

                if(item32.SelectedIndex > 0)
                {
                    item32.SelectedIndex--;
                    (item32.Items[item32.SelectedIndex] as ListViewItem).Focus();
                }
            }
        }


        /// <summary>
        /// ListViewItem 中有Button 时，当点击Button时，其对应的Click事件会被触发，而 ListView所对应的
        ///  SelectionChanged 事件就无法被触发了，这就导致 SelectedIndex 不会产生变化。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item22_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int num = item22.SelectedIndex;
        }

        private void btn01_item22_Click(object sender, RoutedEventArgs e)
        {
            int num1 = item22.SelectedIndex;
            e.Handled = false;
        }

        private void btn02_item22_Click(object sender, RoutedEventArgs e)
        {
            int num2 = item22.SelectedIndex;
            e.Handled = false;
        }

        private void item11_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter || e.Key==Key.Space)
            {
                e.Handled = true;

                ListViewItem obj = item11.ItemContainerGenerator.ContainerFromItem(sender) as ListViewItem;


            }
        }



        private childItem FindVisualChild<childItem>(DependencyObject obj)
                where childItem : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                {
                    return (childItem)child;
                }
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private void item41_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
            {
                e.Handled = true;

                //ListViewItem listViewItem = item41.ItemContainerGenerator.ContainerFromItem(item41.Items.CurrentItem) as ListViewItem;
                ListViewItem listViewItem = sender as ListViewItem;
                ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(listViewItem);
                DataTemplate myDataTemplate = myContentPresenter.ContentTemplate;
                CheckBox cb = myDataTemplate.FindName("myCheckBox", myContentPresenter) as CheckBox;

                if (cb.IsChecked == true)
                {
                    cb.IsChecked = false;
                }
                else
                {
                    cb.IsChecked = true;
                }

                #region 通过代码模拟按键来触发事件：https://stackoverflow.com/questions/1645815/how-can-i-programmatically-generate-keypress-events-in-c
                //   var key = Key.Tab;                    // Key to send
                //   cb.Focus();
                //   var target = cb;                        // Target element
                //   var routedEvent = Keyboard.PreviewKeyDownEvent; // Event to send
                //   target.RaiseEvent(
                //new KeyEventArgs(
                //  Keyboard.PrimaryDevice,
                //  PresentationSource.FromVisual(target),
                //  0,
                //  key)
                //{ RoutedEvent = routedEvent }
                //       );
                #endregion

                cb.Focus();


            }
        }
    }
}
