﻿#pragma checksum "..\..\Sell.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60CDE1F9F60BBE165BD1F4553685006B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
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
using Test;


namespace Test {
    
    
    /// <summary>
    /// Sell
    /// </summary>
    public partial class Sell : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel DownStackPanel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientNameField;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SecondDownPanel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar ChooseDateCalendar;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ButtonsPanel;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\Sell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/sell.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sell.xaml"
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
            this.DownStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.ClientNameField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 30 "..\..\Sell.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnChooseClientButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SecondDownPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.DateTextBox = ((System.Windows.Controls.TextBlock)(target));
            
            #line 44 "..\..\Sell.xaml"
            this.DateTextBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ShowCalendar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChooseDateCalendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 50 "..\..\Sell.xaml"
            this.ChooseDateCalendar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ChooseDate);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 99 "..\..\Sell.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnArticleButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 116 "..\..\Sell.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickExitButton);
            
            #line default
            #line hidden
            return;
            case 10:
            this.listView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
