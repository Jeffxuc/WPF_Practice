using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MyInterface;

namespace MainProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<IMyInterface> myPlugins;
        public MainWindow()
        {
            InitializeComponent();

            //new DirectoryCatalog 的默认加载目录为：该程序的exe文件目录下，为Debug目录或Release目录
            var catalog = new DirectoryCatalog("../../MyPlugins");
            var container = new CompositionContainer(catalog);
            myPlugins = container.GetExportedValues<IMyInterface>();

            foreach (var plg in myPlugins)
            {
                /*该方式只是简单的加载显示，但没有任何事件，点击也无效
                 * string name = plg.GetPluginName();
                this.ItemsList.Items.Add(new TabItem() { Header = name, Content = plg });*/

                Button btn = new Button();
                btn.FontSize = 20;
                btn.FontFamily = new FontFamily("Times New Roman");
                btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.Content = plg.GetPluginName();
                btn.Tag = plg.GetPluginId();
                btn.Click += Btn_Clicked;
                ItemsList.Items.Add(btn);
            }
        }

        private void Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int id = Convert.ToInt32(btn.Tag); //Tag为object类型，需要显示的转换成int类型
            frameContent.Content = myPlugins.ElementAt(id);

        }
    }
}
