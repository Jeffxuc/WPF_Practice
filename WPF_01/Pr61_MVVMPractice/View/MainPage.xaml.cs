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
using Pr61_MVVMPractice.ViewModel;

namespace Pr61_MVVMPractice.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainPage_VM mainPage_VM = new MainPage_VM();
        public MainPage()
        {
            this.DataContext = mainPage_VM;

            mainPage_VM.Age = 20;

            InitializeComponent();

            RegisterEvent();
            
        }

        private void RegisterEvent()
        {
            // btn01, btn02 为MVVM模式下进行的动作。
            btn01.Click += (s1, e1) =>
            {
                mainPage_VM.Age = 26;
                mainPage_VM.City = "ShangHai";
            };

            btn02.Click += (s2, e2) =>
            {
                mainPage_VM.City = "Hangzhou";
                mainPage_VM.Age = 29;
            };

            // btn03 为普通的模式，非MVVM对应的模式。
            btn03.Click += (s3, e3) =>
            {
                if (txt03.Text == "Not MVVM model")
                    txt03.Text = "Just a normal model";
                else
                    txt03.Text = "Not MVVM model";
            };

        }
    }
}
