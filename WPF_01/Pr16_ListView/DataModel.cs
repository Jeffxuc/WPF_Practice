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

    public class WifiDetailCard
    {
        public string img { get; set; }
        public string descText { get; set; }
        public int progressNum { get; set; }

        public WifiDetailCard(string _img, string _descText, int _progressNum)
        {
            img = _img;
            descText = _descText;
            progressNum = _progressNum;
        }

    }

    public class WifiTestData : ObservableCollection<WifiDetailCard>
    {
        public WifiTestData()
        {
            Add(new WifiDetailCard("Image1", "網路裝置及設定", 0));
            Add(new WifiDetailCard("Image2", "網路連線", 0));
        }
    }


    public class CheckBoxInfo
    {
        public string name { get; set; }
        public string index { get; set; }
        public bool ischecked { get; set; }

        public CheckBoxInfo(string _name, string _index, bool _isChecked)
        {
            name = _name;
            index = _index;
            ischecked = _isChecked;
        }
    }

    public class CheckBoxData : ObservableCollection<CheckBoxInfo>
    {
        public CheckBoxData()
        {
            Add(new CheckBoxInfo("A01", "0", false));
            Add(new CheckBoxInfo("A02", "1", false));
            Add(new CheckBoxInfo("A03", "2", true));
            Add(new CheckBoxInfo("A04", "3", false));
        }
    }

}
