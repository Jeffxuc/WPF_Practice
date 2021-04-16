using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr24_Style.SubItem
{
    public class MyData
    {
        public string CityName { set; get; }
        public string CurState { set; get; }

        public MyData(string str1, string str2)
        {
            CityName = str1;
            CurState = str2;
        }
    }

    public class PlacesData : ObservableCollection<MyData>
    {
        public PlacesData()
        {
            Add(new MyData("BeiJing", "On"));
            Add(new MyData("ShangHai", "Off"));
            Add(new MyData("GuangZhou", "No"));
            Add(new MyData("HangZhou", "On"));
            Add(new MyData("NanJin", "To"));
            Add(new MyData("Shenzhen", "On"));
        }
    }
}
