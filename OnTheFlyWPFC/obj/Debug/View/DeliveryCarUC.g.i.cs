﻿#pragma checksum "..\..\..\View\DeliveryCarUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90E40B03A912E46E5A0BF48FAAF830A6BBFD3E7F"
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
    /// DeliveryCarUC
    /// </summary>
    public partial class DeliveryCarUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 341 "..\..\..\View\DeliveryCarUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCarType;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\..\View\DeliveryCarUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchPlateNumber;
        
        #line default
        #line hidden
        
        
        #line 347 "..\..\..\View\DeliveryCarUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchDeliveryCars;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\View\DeliveryCarUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstCarView;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/deliverycaruc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DeliveryCarUC.xaml"
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
            this.cmbCarType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 341 "..\..\..\View\DeliveryCarUC.xaml"
            this.cmbCarType.Loaded += new System.Windows.RoutedEventHandler(this.CmbCarType_Loaded);
            
            #line default
            #line hidden
            
            #line 341 "..\..\..\View\DeliveryCarUC.xaml"
            this.cmbCarType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbCarType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchPlateNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 346 "..\..\..\View\DeliveryCarUC.xaml"
            this.txtSearchPlateNumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearchPlateNumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearchDeliveryCars = ((System.Windows.Controls.Button)(target));
            
            #line 347 "..\..\..\View\DeliveryCarUC.xaml"
            this.btnSearchDeliveryCars.Click += new System.Windows.RoutedEventHandler(this.BtnSearchDeliveryCars_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstCarView = ((System.Windows.Controls.ListView)(target));
            
            #line 354 "..\..\..\View\DeliveryCarUC.xaml"
            this.lstCarView.Loaded += new System.Windows.RoutedEventHandler(this.LstCarView_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 391 "..\..\..\View\DeliveryCarUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCar);
            
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
            
            #line 369 "..\..\..\View\DeliveryCarUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Car);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 378 "..\..\..\View\DeliveryCarUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Car);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

