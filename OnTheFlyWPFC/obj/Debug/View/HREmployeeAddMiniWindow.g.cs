﻿#pragma checksum "..\..\..\View\HREmployeeAddMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37721F77446DA2A02832EC12CA668F97FC63076E"
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
    /// HREmployeeAddMiniWindow
    /// </summary>
    public partial class HREmployeeAddMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone1;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone2;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEmployeeCity;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerStartDate;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEmployeeJob;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEmployeeBranch;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/hremployeeaddminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
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
            
            #line 32 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.BtnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEmployeeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPhone1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPhone2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmbEmployeeCity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 82 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
            this.cmbEmployeeCity.Loaded += new System.Windows.RoutedEventHandler(this.cmbEmployeeCity_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.datePickerStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.cmbEmployeeJob = ((System.Windows.Controls.ComboBox)(target));
            
            #line 101 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
            this.cmbEmployeeJob.Loaded += new System.Windows.RoutedEventHandler(this.cmbEmployeeJob_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbEmployeeBranch = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
            this.cmbEmployeeBranch.Loaded += new System.Windows.RoutedEventHandler(this.cmbEmployeeBranch_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAddEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\View\HREmployeeAddMiniWindow.xaml"
            this.btnAddEmployee.Click += new System.Windows.RoutedEventHandler(this.btnAddEmployee_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

