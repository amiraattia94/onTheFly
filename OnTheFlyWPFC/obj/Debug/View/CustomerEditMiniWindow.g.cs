﻿#pragma checksum "..\..\..\View\CustomerEditMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38133DFF0F1C0F7AF0E523BF1AEF59D8B1629286"
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
    /// CustomerEditMiniWindow
    /// </summary>
    public partial class CustomerEditMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkCustomerEdit;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerPhone1;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerPhone2;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbcustomerCities;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerAddress;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\CustomerEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerCredit;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/customereditminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CustomerEditMiniWindow.xaml"
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
            
            #line 32 "..\..\..\View\CustomerEditMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.btnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stkCustomerEdit = ((System.Windows.Controls.StackPanel)(target));
            
            #line 63 "..\..\..\View\CustomerEditMiniWindow.xaml"
            this.stkCustomerEdit.Loaded += new System.Windows.RoutedEventHandler(this.StkCustomerEdit_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCustomerPhone1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCustomerPhone2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmbcustomerCities = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\..\View\CustomerEditMiniWindow.xaml"
            this.cmbcustomerCities.Loaded += new System.Windows.RoutedEventHandler(this.cmbcustomerCities_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtCustomerAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtCustomerCredit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 90 "..\..\..\View\CustomerEditMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

