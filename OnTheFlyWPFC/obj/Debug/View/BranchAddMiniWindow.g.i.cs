﻿#pragma checksum "..\..\..\View\BranchAddMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8859B2D8285F2BA46F9E9CAC7E5F0B20835BA462"
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
    /// BranchAddMiniWindow
    /// </summary>
    public partial class BranchAddMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 345 "..\..\..\View\BranchAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\View\BranchAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBranchName;
        
        #line default
        #line hidden
        
        
        #line 365 "..\..\..\View\BranchAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBranchCities;
        
        #line default
        #line hidden
        
        
        #line 368 "..\..\..\View\BranchAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBranchAddress;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\..\View\BranchAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBranchStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/branchaddminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\BranchAddMiniWindow.xaml"
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
            
            #line 345 "..\..\..\View\BranchAddMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.BtnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBranchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbBranchCities = ((System.Windows.Controls.ComboBox)(target));
            
            #line 365 "..\..\..\View\BranchAddMiniWindow.xaml"
            this.cmbBranchCities.Loaded += new System.Windows.RoutedEventHandler(this.cmbBranchCities_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBranchAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cmbBranchStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 389 "..\..\..\View\BranchAddMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

