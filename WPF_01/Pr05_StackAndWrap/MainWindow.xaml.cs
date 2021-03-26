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

namespace Pr05_StackAndWrap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();

            /*StackPanelControls stackPanel = new StackPanelControls();
            stackPanel.Show();
            stackPanel.Topmost = true;*/

            /*StackPanelWithFour sp02 = new StackPanelWithFour();
            sp02.Show();*/

            /*DesignAButton desBtn = new DesignAButton();
            desBtn.Show();*/

            /*TuneTheBtn tuneTheBtn = new TuneTheBtn();
            tuneTheBtn.Show();*/

            ExploreDirectories exp = new ExploreDirectories();
            exp.Show();



        }
    }
}
