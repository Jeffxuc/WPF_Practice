using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr62_MVVMExample.ViewModel;

namespace Pr62_MVVMExample.Model
{
    /// <summary>
    /// Define your self data model as the Model Section.
    /// </summary>
    class PersonData : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(value != name)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if(value != address)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
