using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr61_MVVMPractice.ViewModel
{
    class MainPage_VM: ViewModelBase
    {
        private string city="suzhou";
        public string City
        {
            get { return city; }
            set
            {
                if(value!=city)
                {
                    city = value;
                    OnPropertyChanged();
                }

            }
        }

        private int age;
        public int Age
        {
            get {return age;}
            set
            {
                if(value!=age)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }


    }
}
