﻿#pragma checksum "..\..\DetailPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D26AB174BC2B5E942C75CA414A36944CFA7BA8C1F3CC74751A0C487146BE2C74"
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
    /// DetailPage
    /// </summary>
    public partial class DetailPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox paycombobox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namebox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextbtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Emailbox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tableNoBox;
        
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
            System.Uri resourceLocater = new System.Uri("/RestuaruntApp;component/detailpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DetailPage.xaml"
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
            
            #line 12 "..\..\DetailPage.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Sizeup);
            
            #line default
            #line hidden
            
            #line 12 "..\..\DetailPage.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.sizedown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.paycombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\DetailPage.xaml"
            this.paycombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.paycombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.namebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nextbtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\DetailPage.xaml"
            this.nextbtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 31 "..\..\DetailPage.xaml"
            this.nextbtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.sizeups);
            
            #line default
            #line hidden
            
            #line 31 "..\..\DetailPage.xaml"
            this.nextbtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.sizedowns);
            
            #line default
            #line hidden
            return;
            case 5:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\DetailPage.xaml"
            this.backbtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.sizeups);
            
            #line default
            #line hidden
            
            #line 32 "..\..\DetailPage.xaml"
            this.backbtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.sizedowns);
            
            #line default
            #line hidden
            
            #line 32 "..\..\DetailPage.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Emailbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tableNoBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

