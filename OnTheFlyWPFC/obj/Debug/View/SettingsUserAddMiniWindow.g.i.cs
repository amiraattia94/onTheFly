﻿#pragma checksum "..\..\..\View\SettingsUserAddMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9DF3FE47A8524953457178B55163F4A12F3E230"
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
    /// SettingsUserAddMiniWindow
    /// </summary>
    public partial class SettingsUserAddMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 345 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 363 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 382 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbPassword;
        
        #line default
        #line hidden
        
        
        #line 401 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbUserEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/settingsuseraddminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
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
            
            #line 320 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCloseForm = ((System.Windows.Controls.Button)(target));
            
            #line 345 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.BtnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.pbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.cmbUserEmployee = ((System.Windows.Controls.ComboBox)(target));
            
            #line 401 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
            this.cmbUserEmployee.Loaded += new System.Windows.RoutedEventHandler(this.cmbUserEmployee_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 420 "..\..\..\View\SettingsUserAddMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

