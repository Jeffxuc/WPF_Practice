﻿#pragma checksum "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946CB39B3934E365E7BB7A17A69223E1B1E7C163"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pr25_Templates.SubItem.DumpControlTemplate;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Pr25_Templates.SubItem.DumpControlTemplate {
    
    
    /// <summary>
    /// DumpControlTemplate
    /// </summary>
    public partial class DumpControlTemplate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemTemplate;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemItemsPanel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pr25_Templates;component/subitem/dumpcontroltemplate/dumpcontroltemplate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
            ((Pr25_Templates.SubItem.DumpControlTemplate.ControlMenuItem)(target)).AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.ControlItemOnClick));
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
            ((System.Windows.Controls.MenuItem)(target)).SubmenuOpened += new System.Windows.RoutedEventHandler(this.DumpOnOpened);
            
            #line default
            #line hidden
            return;
            case 3:
            this.itemTemplate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
            this.itemTemplate.Click += new System.Windows.RoutedEventHandler(this.DumpTemplateOnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.itemItemsPanel = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\..\..\SubItem\DumpControlTemplate\DumpControlTemplate.xaml"
            this.itemItemsPanel.Click += new System.Windows.RoutedEventHandler(this.DumpItemsPanelOnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.txtbox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

