using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pr25_Templates.SubItem.DumpControlTemplate
{
    class ControlMenuItem:MenuItem
    {
        public ControlMenuItem()
        {
            Assembly asbly = Assembly.GetAssembly(typeof(Control));
            Type[] type = asbly.GetTypes();

            SortedList<string, MenuItem> sortlist = new SortedList<string, MenuItem>();
            Header = "Control";
            Tag = typeof(Control);
            sortlist.Add("Control", this);

            foreach(Type tp in type)
            {
                if(tp.IsPublic && tp.IsSubclassOf(typeof(Control)))
                {
                    MenuItem item = new MenuItem();
                    item.Header = tp.Name;
                    item.Tag = tp;
                    sortlist.Add(tp.Name, item);
                }
            }

            foreach(KeyValuePair<string,MenuItem> kvp in sortlist)
            {
                if(kvp.Key!="Control")
                {
                    string strParent = ((Type)kvp.Value.Tag).BaseType.Name;
                    MenuItem itemParent = sortlist[strParent];
                    itemParent.Items.Add(kvp.Value);
                }
            }

            foreach(KeyValuePair<string,MenuItem> kvp in sortlist)
            {
                Type tp = (Type)kvp.Value.Tag;

                if(tp.IsAbstract && kvp.Value.Items.Count==0)
                {
                    kvp.Value.IsEnabled = false;
                }
                if(!tp.IsAbstract && kvp.Value.Items.Count>0)
                {
                    MenuItem item = new MenuItem();
                    item.Header = kvp.Value.Header as string;
                    item.Tag = tp;
                    kvp.Value.Items.Insert(0, item);
                }
            }
        }

    }
}
