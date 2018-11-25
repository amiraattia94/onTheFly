﻿#pragma checksum "..\..\..\View\CustomerViewUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36DBBDD8C7695B5F795FBC943AF8F28662A2D5CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using OnTheFlyWPFC.View;
using OnTheFlyWPFC.ViewModel;
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


namespace OnTheFlyWPFC.View {
    
    
    /// <summary>
    /// CustomerViewUC
    /// </summary>
    public partial class CustomerViewUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 341 "..\..\..\View\CustomerViewUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomerCity;
        
        #line default
        #line hidden
        
        
        #line 345 "..\..\..\View\CustomerViewUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSearchType;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\View\CustomerViewUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchCustomerName;
        
        #line default
        #line hidden
        
        
        #line 361 "..\..\..\View\CustomerViewUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstviewCustomers;
        
        #line default
        #line hidden
        
        
        #line 409 "..\..\..\View\CustomerViewUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCustomer;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/customerviewuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CustomerViewUC.xaml"
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
            this.cmbCustomerCity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 341 "..\..\..\View\CustomerViewUC.xaml"
            this.cmbCustomerCity.Loaded += new System.Windows.RoutedEventHandler(this.cmbCustomerCity_Loaded);
            
            #line default
            #line hidden
            
            #line 341 "..\..\..\View\CustomerViewUC.xaml"
            this.cmbCustomerCity.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbCustomerCity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbSearchType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtSearchCustomerName = ((System.Windows.Controls.TextBox)(target));
            
            #line 354 "..\..\..\View\CustomerViewUC.xaml"
            this.txtSearchCustomerName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearchCustomerName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstviewCustomers = ((System.Windows.Controls.ListView)(target));
            
            #line 361 "..\..\..\View\CustomerViewUC.xaml"
            this.lstviewCustomers.Loaded += new System.Windows.RoutedEventHandler(this.lstviewCustomers_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 409 "..\..\..\View\CustomerViewUC.xaml"
            this.btnAddCustomer.Click += new System.Windows.RoutedEventHandler(this.btnAddCustomer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 375 "..\..\..\View\CustomerViewUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Memberships);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 378 "..\..\..\View\CustomerViewUC.xaml"
            ((System.Windows.Controls.TextBlock)(target)).Loaded += new System.Windows.RoutedEventHandler(this.TxtMembershipCount_Loaded);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 388 "..\..\..\View\CustomerViewUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditCustomer);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 397 "..\..\..\View\CustomerViewUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCustomer);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

