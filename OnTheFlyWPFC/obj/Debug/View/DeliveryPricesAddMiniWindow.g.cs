﻿#pragma checksum "..\..\..\View\DeliveryPricesAddMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12FAFC6181DECBCC8E373F7B8A4C4217F52F4986"
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
    /// DeliveryPricesAddMiniWindow
    /// </summary>
    public partial class DeliveryPricesAddMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceType;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomerLocation;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVendorLocation;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullPrice;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHalfPrice;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceState;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/deliverypricesaddminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
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
            this.btnCloseForm = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.BtnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbServiceType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
            this.cmbServiceType.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceType_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbCustomerLocation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
            this.cmbCustomerLocation.Loaded += new System.Windows.RoutedEventHandler(this.cmbCustomerLocation_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbVendorLocation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
            this.cmbVendorLocation.Loaded += new System.Windows.RoutedEventHandler(this.cmbVendorLocation_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtFullPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtHalfPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cmbServiceState = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 88 "..\..\..\View\DeliveryPricesAddMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
