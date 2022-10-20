using System;
using System.Windows.Automation;
using System.Windows.Controls;

/****************** Narrator 的一些规则 *********************
 * 一般读取内容方式："控件内容属性值"+"控件类型"+"控件的HelpText值(如果存在的话)"
 * 
 * 1. Button控件为例：
 * 1). 当设置读取Button的内容时，优先级顺序为：AutomationProperties.Name > AutomationProperties.LabeledBy > Content中的字串
 *     按照优先级的顺序只选存在的最高级别的内容来读取，若没有的话，依次往后推
 * 
 ***************************************************/


namespace Pr44_Narrator.SubItems
{
    /// <summary>
    /// Interaction logic for Frame_01.xaml
    /// </summary>
    public partial class Frame_01 : UserControl
    {
        public Frame_01()
        {
            InitializeComponent();

            TestNarrator();
        }

        private void TestNarrator()
        {
            AutomationProperties.SetHelpText(testBtn1, "help content infomation.");
            //AutomationProperties.SetItemStatus(testBtn1, "Now select it");
            AutomationProperties.SetItemType(testBtn1, "Image");


            testBtn2.SetValue(AutomationProperties.NameProperty, "new string");
        }
    }
}
