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
    public partial class UserControl1 : UserControl,IMyInterface
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public int GetPluginId()
        {
            return 1;
        }

        public string GetPluginName()
        {
            return "This is Plugin B";
        }
    }
}
