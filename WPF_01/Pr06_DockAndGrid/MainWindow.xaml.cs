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

namespace Pr06_DockAndGrid
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

            /*Docker docker = new Docker();
            docker.Show();*/

            /*MeetTheDocker meetDock = new MeetTheDocker();
            meetDock.Show();*/

            /*UseGrid useGrid = new UseGrid();
            useGrid.Show();*/

            /*CalculateYourLife cyl = new CalculateYourLife();
            cyl.Show();*/

            /*GridSpliter split = new GridSpliter();
            split.Show();*/

            /*UseSpliter useSpliter = new UseSpliter();
            useSpliter.Show();*/

            ScrollColor sc = new ScrollColor();
            sc.Show();
        }
    }
}
