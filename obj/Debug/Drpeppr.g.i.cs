﻿#pragma checksum "..\..\Drpeppr.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ADB3F189797399E0A73AB55F71D4B51E3BB90CFD4F4F73B8942833580720FCDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RestuaruntApp;
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


namespace RestuaruntApp {
    
    
    /// <summary>
    /// Drpeppr
    /// </summary>
    public partial class Drpeppr : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pricebox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantitybcw;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minze;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pluse;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCartbtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton large;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton small;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bugersizeimge;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Drpeppr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock sizeblock;
        
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
            System.Uri resourceLocater = new System.Uri("/RestuaruntApp;component/drpeppr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Drpeppr.xaml"
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
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Drpeppr.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pricebox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.quantitybcw = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\Drpeppr.xaml"
            this.quantitybcw.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.quantity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.minze = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Drpeppr.xaml"
            this.minze.Click += new System.Windows.RoutedEventHandler(this.minze_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pluse = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Drpeppr.xaml"
            this.pluse.Click += new System.Windows.RoutedEventHandler(this.pluse_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addCartbtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Drpeppr.xaml"
            this.addCartbtn.Click += new System.Windows.RoutedEventHandler(this.addCartbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.large = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\Drpeppr.xaml"
            this.large.Checked += new System.Windows.RoutedEventHandler(this.large_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.small = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\Drpeppr.xaml"
            this.small.Checked += new System.Windows.RoutedEventHandler(this.small_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bugersizeimge = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.sizeblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

