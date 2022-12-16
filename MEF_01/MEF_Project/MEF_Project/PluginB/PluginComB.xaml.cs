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
using MyInterface;

namespace PluginB
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 
    [Export(typeof(IMyInterface))]
    public partial class PluginComB : UserControl,IMyInterface
    {
        public PluginComB()
        {
            InitializeComponent();

            btn03.Click += Btn03_Click;
            EventReceiveData += ReceiveDataCallBack;
        }

        private void Btn03_Click(object sender, RoutedEventArgs e)
        {
            EventRequestData?.Invoke(2, "Come from plugin 02", EventReceiveData);
        }

        #region Interface 里面的函数和委托都必须要在派生类中来进行实现
        public event EventHandlerReceiveData EventReceiveData;
        public event EventHandlerRequestData EventRequestData;

        public int GetPluginId()
        {
            return 1;
        }

        public string GetPluginName()
        {
            return "This is Plugin B";
        }

        /// <summary>
        /// 用来接受主页面或其它Plugin发送的消息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="receiveData"></param>
        public void ReceiveDataCallBack(int id, string receiveData)
        {
            txt.Text = id.ToString() + "--" + receiveData;
        }

        #endregion
    }
}
