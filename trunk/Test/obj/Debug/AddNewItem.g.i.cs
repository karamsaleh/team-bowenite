﻿#pragma checksum "..\..\AddNewItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBF3EC7321C83A6DA20D7AFBF8D62CF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Test {
    
    
    /// <summary>
    /// AddNewItem
    /// </summary>
    public partial class AddNewItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbID;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbStock;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbService;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HiddenMeasurementBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMeasurement;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbValue;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSellPrice;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\AddNewItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiscount;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/addnewitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewItem.xaml"
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
            this.tbID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.rbStock = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\AddNewItem.xaml"
            this.rbStock.Checked += new System.Windows.RoutedEventHandler(this.OnStockRadioButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbService = ((System.Windows.Controls.RadioButton)(target));
            
            #line 82 "..\..\AddNewItem.xaml"
            this.rbService.Checked += new System.Windows.RoutedEventHandler(this.OnServiceRadioButton);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HiddenMeasurementBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.cbMeasurement = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.tbValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbSellPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 125 "..\..\AddNewItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddButtonClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 128 "..\..\AddNewItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

