﻿#pragma checksum "..\..\..\View\POSAddServiceMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C3E09CE80AEBD9F487D8D3CFD471E89CE19AD37"
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
    /// POSAddServiceMiniWindow
    /// </summary>
    public partial class POSAddServiceMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceType;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVendors;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBranches;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTrip;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPaid;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDeliveryPrice;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPaidPrice;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\View\POSAddServiceMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerStartDate;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/posaddserviceminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\POSAddServiceMiniWindow.xaml"
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
            
            #line 16 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCloseForm = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.btnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbServiceType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbServiceType.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceType_Loaded);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbServiceType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbServiceType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbVendors = ((System.Windows.Controls.ComboBox)(target));
            
            #line 83 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbVendors.Loaded += new System.Windows.RoutedEventHandler(this.CmbVendors_Loaded);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbVendors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbVendors_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbBranches = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbBranches.Loaded += new System.Windows.RoutedEventHandler(this.CmbBranches_Loaded);
            
            #line default
            #line hidden
            
            #line 86 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbBranches.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbBranches_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbTrip = ((System.Windows.Controls.ComboBox)(target));
            
            #line 90 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbTrip.Loaded += new System.Windows.RoutedEventHandler(this.CmbTrip_Loaded);
            
            #line default
            #line hidden
            
            #line 90 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbTrip.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbTrip_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbPaid = ((System.Windows.Controls.ComboBox)(target));
            
            #line 102 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbPaid.Loaded += new System.Windows.RoutedEventHandler(this.CmbPaid_Loaded);
            
            #line default
            #line hidden
            
            #line 102 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.cmbPaid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbPaid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblTotalPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtDeliveryPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txtPaidPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 145 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.txtPaidPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPaidPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.datePickerStartDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 153 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            this.datePickerStartDate.Loaded += new System.Windows.RoutedEventHandler(this.DatePickerStartDate_Loaded);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 165 "..\..\..\View\POSAddServiceMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddService_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

