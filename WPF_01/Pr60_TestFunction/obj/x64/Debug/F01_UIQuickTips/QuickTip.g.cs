#pragma checksum "..\..\..\..\F01_UIQuickTips\QuickTip.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C7327A53FAFD14B720C5014EA025FFD40789C32"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pr60_TestFunction.F01_UIQuickTips;
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


namespace Pr60_TestFunction.F01_UIQuickTips {
    
    
    /// <summary>
    /// QuickTip
    /// </summary>
    public partial class QuickTip : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Pr60_TestFunction.F01_UIQuickTips.QuickTip tips;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbStep;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbDiscrible;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/Pr60_TestFunction;component/f01_uiquicktips/quicktip.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
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
            this.tips = ((Pr60_TestFunction.F01_UIQuickTips.QuickTip)(target));
            return;
            case 2:
            this.tbStep = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbDiscrible = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\F01_UIQuickTips\QuickTip.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

