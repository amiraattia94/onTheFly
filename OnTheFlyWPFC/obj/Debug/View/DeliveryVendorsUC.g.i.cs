﻿#pragma checksum "..\..\..\View\DeliveryVendorsUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0D8DB0C20C314A5E402BC1847A5B6F9C0A51929"
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
    /// DeliveryVendorsUC
    /// </summary>
    public partial class DeliveryVendorsUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 339 "..\..\..\View\DeliveryVendorsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceType;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\..\View\DeliveryVendorsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceState;
        
        #line default
        #line hidden
        
        
        #line 352 "..\..\..\View\DeliveryVendorsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchDistinationName;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\View\DeliveryVendorsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchDeliveryDestination;
        
        #line default
        #line hidden
        
        
        #line 361 "..\..\..\View\DeliveryVendorsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstViewDeliveryDistination;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/deliveryvendorsuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DeliveryVendorsUC.xaml"
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
            this.cmbServiceType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 339 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.cmbServiceType.Loaded += new System.Windows.RoutedEventHandler(this.cmbServiceType_Loaded);
            
            #line default
            #line hidden
            
            #line 339 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.cmbServiceType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbServiceType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbServiceState = ((System.Windows.Controls.ComboBox)(target));
            
            #line 342 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.cmbServiceState.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbServiceState_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSearchDistinationName = ((System.Windows.Controls.TextBox)(target));
            
            #line 352 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.txtSearchDistinationName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearchDistinationName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSearchDeliveryDestination = ((System.Windows.Controls.Button)(target));
            
            #line 354 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.btnSearchDeliveryDestination.Click += new System.Windows.RoutedEventHandler(this.BtnSearchDeliveryDestination_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstViewDeliveryDistination = ((System.Windows.Controls.ListView)(target));
            
            #line 361 "..\..\..\View\DeliveryVendorsUC.xaml"
            this.lstViewDeliveryDistination.Loaded += new System.Windows.RoutedEventHandler(this.LstViewDeliveryDistination_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 405 "..\..\..\View\DeliveryVendorsUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
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
            case 6:
            
            #line 369 "..\..\..\View\DeliveryVendorsUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.VendorBranches_click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 372 "..\..\..\View\DeliveryVendorsUC.xaml"
            ((System.Windows.Controls.TextBlock)(target)).Loaded += new System.Windows.RoutedEventHandler(this.TxtVendorBranchCount_Loaded);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 383 "..\..\..\View\DeliveryVendorsUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditVendor);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 392 "..\..\..\View\DeliveryVendorsUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteVendor);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

