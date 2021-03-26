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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;
using PluginInterface;
using System.ComponentModel.Composition.Hosting;

namespace MyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<IMyPlugin> myPlugins;
        public MainWindow()
        {
            InitializeComponent();

            //new DirectoryCatalog 的默认加载目录为：该程序的exe文件目录下，为Debug目录或Release目录
            var catalog = new DirectoryCatalog("../../MyPlugins");
            var container = new CompositionContainer(catalog);
            myPlugins = container.GetExportedValues<IMyPlugin>();

            foreach(var plg in myPlugins)
            {
                /*该方式只是简单的加载显示，但没有任何事件，点击也无效
                 * string name = plg.GetPluginName();
                this.pageList.Items.Add(new TabItem() { Header = name, Content = plg });*/

                Button btn = new Button();
                btn.FontSize = 20;
                btn.FontFamily = new FontFamily("Times New Roman");
                btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.Content = plg.GetPluginName();
                btn.Tag = plg.GetPluginId();
                btn.Click += Btn_Clicked;
                pageList.Items.Add(btn);
                
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
