using System.Windows.Controls;
using System.ComponentModel.Composition;
using MyInterface;

namespace PluginA
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>

    // 导入该接口
    [Export(typeof(IMyInterface))]
    public partial class UserControl1 : UserControl, IMyInterface
    {
        public UserControl1()
        {
            InitializeComponent();
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
    }
}
