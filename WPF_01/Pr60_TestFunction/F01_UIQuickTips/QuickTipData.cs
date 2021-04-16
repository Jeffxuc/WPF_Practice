using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pr60_TestFunction.F01_UIQuickTips
{
    public class QuickTipData
    {
        private FrameworkElement _UITip;
        private string _UIContent;

        public QuickTipData(FrameworkElement framework,string strContent)
        {
            UITip = framework;
            UIContent = strContent;
        }

        public FrameworkElement UITip
        {
            get
            {
                return _UITip;
            }
            set
            {
                _UITip = value;
            }
        }

        public string UIContent
        {
            get
            {
                return _UIContent;
            }
            set
            {
                _UIContent = value;
            }
        }
    }
}
