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
using System.Windows.Shapes;

namespace Pr19_XMAL.SubItem
{
    /// <summary>
    /// Interaction logic for UseCenterButtonWindow.xaml
    /// </summary>
    public partial class UseCenterButtonWindow : Window
    {
        public UseCenterButtonWindow()
        {
            InitializeComponent();
            SizeToContent = SizeToContent.Height;

            for(int i=0;i<5;++i)
            {
                CenterButton cbtn = new CenterButton();
                cbtn.Content = "Button No " + (i + 5);
                stackPL.Children.Add(cbtn);
            }
        }
    }
}
