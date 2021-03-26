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
using MyPluginInterface;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace WpfMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Assembly asm01 = Assembly.LoadFrom("D:\\WSpace\\WPFProject\\MEF_Pra01\\WpfExe\\MyPluginA\\bin\\Debug\\MyPluginA.dll");

            Console.WriteLine();

        }
    }
}
