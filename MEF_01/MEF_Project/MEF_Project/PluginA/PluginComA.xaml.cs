using System.Windows.Controls;
using System.ComponentModel.Composition;
using System.Windows;
using MyInterface;
using System.Windows.Media;

namespace PluginA
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>

    // 导入该接口
    [Export(typeof(IMyInterface))]
    public partial class PluginComA : UserControl, IMyInterface
    {
        public PluginComA()
        {
            InitializeComponent();
            EventReceiveData += ReceiveDataCallBack;

            comABtn.Click += ComABtn_Click;

            PluginASelfFunc();
        }

        public event EventHandlerReceiveData EventReceiveData;
        public event EventHandlerRequestData EventRequestData;

        private void ComABtn_Click(object sender, RoutedEventArgs e)
        {
            //向主页面发送消息，
            EventRequestData?.Invoke(1, "Message 01", EventReceiveData);
        }

        public void PluginASelfFunc()
        {
            getTxt.Foreground = Brushes.HotPink;
        }

        //对接口IMyInterface的实现
        public int GetPluginId()
        {
            return 0;
        }

        public string GetPluginName()
        {
            return "This is Plugin A";
        }

        /// <summary>
        /// 用来接受主页面或其它Plugin发送来的消息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="receiveData"></param>
        public void ReceiveDataCallBack(int id, string receiveData)
        {
            getTxt.Text = id.ToString() + "--" + receiveData;
            
        }
    }
}
