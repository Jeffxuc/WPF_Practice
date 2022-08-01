using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;
using Pr43_Command01.Model;

namespace Pr43_Command01.ViewModel
{
    class Person_VM : INotifyPropertyChanged
    {
        int count = 0;
        private Person_Model person_model;
        public Person_Model person_Model
        {
            get { return person_model; }
            set
            {
                if(person_model != value)
                {
                    person_model = value;
                }
            }
        }

        public string FirstName
        {
            get { return person_Model.FirstName; }
            set
            {
                if(value!= person_Model.FirstName)
                {
                    person_Model.FirstName = value;
                    OnPropertyChanged();
                }
            }
        }

        public Person_VM()
        {
            person_model = new Person_Model() { FirstName = "Tims", Age = 18 };
        }

        public ICommand MyCmd { get; set; }

        private bool canExecuteMyMethod(Object parameter)
        {
            if (string.IsNullOrEmpty(person_Model.FirstName) || person_Model.FirstName == "")
                return false;
            else
                return true;
        }
        

        private void ExecuteMyMethod(object parameter)
        {
            count++;
            person_Model.FirstName = person_Model.FirstName + count;
            MessageBox.Show("Hello,  " + person_Model.FirstName);
        }

        #region Implement the "INotifyPropertyChanged" interface in ViewModel
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion




    }
}
