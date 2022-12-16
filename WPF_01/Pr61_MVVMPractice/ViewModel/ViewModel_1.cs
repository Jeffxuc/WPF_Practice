using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr61_MVVMPractice.ViewModel
{
    class ViewModel_1 : ViewModelBase
    {
        private string _City;
        private int _NumCode;

        public string City
        {
            get { return _City; }
            set
            {
                if(_City != value)
                {
                    _City = value;
                    OnPropertyChanged();
                }
            }
        }

        public int NumCode
        {
            get { return _NumCode; }
            set
            {
                if(_NumCode != value)
                {
                    _NumCode = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
