using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr16_ListView
{
    public class DataModel: ObservableCollection<CityInfo>
    {
        public DataModel()
        {
            Add(new CityInfo("Suzhou", 1001));
            Add(new CityInfo("Hangzhou", 1002));
            Add(new CityInfo("ShangHai", 1003));
            Add(new CityInfo("Nanjin", 1004));
            Add(new CityInfo("Beijin", 1005));
            Add(new CityInfo("Guangzhou", 1006));

        }
    }

    public class CityInfo
    {
        public string cityName { get; set; }
        public int cityNum { get; set; }

        public CityInfo(string name, int num)
        {
            cityName = name;
            cityNum = num;
        }
    }
}
