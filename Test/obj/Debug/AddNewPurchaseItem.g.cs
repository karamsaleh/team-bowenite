﻿#pragma checksum "..\..\AddNewPurchaseItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2834E196B5F9BC6C5D046A8F60F95789"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    /// AddNewPurchaseItem
    /// </summary>
    public partial class AddNewPurchaseItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\AddNewPurchaseItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton StockRB;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddNewPurchaseItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ServiceRB;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AddNewPurchaseItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HiddenMeasurementBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AddNewPurchaseItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MeasurementCB;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/addnewpurchaseitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewPurchaseItem.xaml"
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
            this.StockRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\AddNewPurchaseItem.xaml"
            this.StockRB.Checked += new System.Windows.RoutedEventHandler(this.OnStockRadioButton);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ServiceRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 82 "..\..\AddNewPurchaseItem.xaml"
            this.ServiceRB.Checked += new System.Windows.RoutedEventHandler(this.OnServiceRadioButton);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HiddenMeasurementBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.MeasurementCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 124 "..\..\AddNewPurchaseItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 127 "..\..\AddNewPurchaseItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

