﻿#pragma checksum "..\..\ArticleChoice.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B8CAFC9A23D73F19C8FEA2E09D94BC9B"
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
using Test.Properties;


namespace Test {
    
    
    /// <summary>
    /// ArticleChoice
    /// </summary>
    public partial class ArticleChoice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgArticles;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ArticleDetails;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbArticleName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbQuantity;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSellPrice;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiscount;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ArticleChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/articlechoice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ArticleChoice.xaml"
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
            this.dgArticles = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\ArticleChoice.xaml"
            this.dgArticles.Loaded += new System.Windows.RoutedEventHandler(this.ArticlesGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 40 "..\..\ArticleChoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnChoiceButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\ArticleChoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCloseClickButton);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\ArticleChoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddNewButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ArticleDetails = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.tbArticleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbSellPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\ArticleChoice.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.AddItemForSell);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 68 "..\..\ArticleChoice.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

