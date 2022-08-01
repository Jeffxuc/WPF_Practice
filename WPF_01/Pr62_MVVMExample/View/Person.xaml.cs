﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pr62_MVVMExample.View
{
    /// <summary>
    /// Interaction logic for Person.xaml
    /// </summary>
    public partial class Person : Page
    {
        public Person()
        {
            ViewModel.PersonViewModel pvm = new ViewModel.PersonViewModel();
            this.DataContext = pvm;

            InitializeComponent();
            
        }
    }
}
