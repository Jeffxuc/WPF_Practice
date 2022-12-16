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
        //因为各个子 Plugin 已经注册了该事件，因此可以在主页通过触发该事件,来达到向各个子Plugin广播的效果
        public event EventHandlerReceiveData BroadcastEvent;
        static int id = 100;

        private IEnumerable<IMyInterface> myPlugins;
        public MainWindow()
        {
            InitializeComponent();

            //new DirectoryCatalog 的默认加载目录为：该程序的exe文件目录下，为Debug目录或Release目录
            var catalog = new DirectoryCatalog("../../MyPlugins");
            var container = new CompositionContainer(catalog);

            //在此将获取派生类中的所有 IMyInterface 类型的值，如果不是从IMyInterface中派生而来的，就不会获取
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

                //主页面为各个Plugin注册接受请求数据事件，用来接受各个子Plugin发送来的信息。
                plg.EventRequestData += Plg_EventRequestData;

                //注册广播事件，主页面向各子Plugin广播发送数据，将各Plugin中实现的接受数据函数注册到该事件上
                BroadcastEvent += plg.ReceiveDataCallBack;

                btn.Click += Btn_Clicked;
                ItemsList.Items.Add(btn);

                
            }
        }

        private void Plg_EventRequestData(int senderID, string requestData, EventHandlerReceiveData receiveEvent)
        {
            if(senderID==1)
            {
                showTxt.Text = requestData;
                showTxt.Foreground = Brushes.Red;
            }
            else if(senderID==2)
            {
                showTxt.Text = requestData;
                showTxt.Foreground = Brushes.DeepPink;

                receiveEvent?.Invoke(999, "The main page trigger this event.");
            }
            else
            {
                showTxt.Text = "Can't receive any data";
                showTxt.Foreground = Brushes.Black;
            }
        }

        private void Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int id = Convert.ToInt32(btn.Tag); //Tag为object类型，需要显示的转换成int类型
            frameContent.Content = myPlugins.ElementAt(id);

        }

        private void triggerEvent_Click(object sender, RoutedEventArgs e)
        {
            BroadcastEvent?.Invoke(id++, "The Main Page Broadcast message to all plugins.");
        }
    }
}
