﻿#pragma checksum "..\..\..\View\DeliveryPricesEditMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED3A6023E2102081F31FD849532DFAFC49A5DDBA"
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
using OnTheFlyWPFC.Behaviors;
using OnTheFlyWPFC.View;
using RootLibrary.WPF.Localization;
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
    /// DeliveryPricesEditMiniWindow
    /// </summary>
    public partial class DeliveryPricesEditMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkEditDeliveryPrice;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceType;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomerLocation;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVendorLocation;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullPrice;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHalfPrice;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/deliverypriceseditminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 31 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.BtnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stkEditDeliveryPrice = ((System.Windows.Controls.StackPanel)(target));
            
            #line 62 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.stkEditDeliveryPrice.Loaded += new System.Windows.RoutedEventHandler(this.StkEditDeliveryPrice_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbServiceType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.cmbServiceType.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceType_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbCustomerLocation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.cmbCustomerLocation.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceType_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbVendorLocation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 105 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.cmbVendorLocation.Loaded += new System.Windows.RoutedEventHandler(this.cmbVendorLocation_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtFullPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtHalfPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cmbServiceState = ((System.Windows.Controls.ComboBox)(target));
            
            #line 163 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            this.cmbServiceState.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceState_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 187 "..\..\..\View\DeliveryPricesEditMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

