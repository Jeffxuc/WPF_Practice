using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr62_MVVMExample.Model;

namespace Pr62_MVVMExample.ViewModel
{
    class PersonViewModel
    {
        private IList<PersonData> personList;
        public IList<PersonData> PersonList
        {
            get { return personList; }
            set
            {
                if(value!=personList)
                {
                    personList = value;

                }
            }
        }

        public PersonViewModel()
        {
            personList = new List<PersonData>()
            {
                new PersonData(){Name="Tom",Address="Suzhou"},
                new PersonData(){Name="John",Address="Hangzhou"},
                new PersonData(){Name="Jeff",Address="Nanjin"},
                new PersonData(){Name="Dong",Address="Guangzhou"}
            };
        }


    }
}
