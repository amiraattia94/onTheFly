﻿#pragma checksum "..\..\..\View\SettingsUserEditMiniWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47D12B3E9993CB4861332AEE825A63C21CE86D37"
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
    /// SettingsUserEditMiniWindow
    /// </summary>
    public partial class SettingsUserEditMiniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseForm;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StkEditUser;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/OnTheFlyWPFC;component/view/settingsusereditminiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
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
            
            #line 31 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
            this.btnCloseForm.Click += new System.Windows.RoutedEventHandler(this.btnCloseForm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StkEditUser = ((System.Windows.Controls.StackPanel)(target));
            
            #line 61 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
            this.StkEditUser.Loaded += new System.Windows.RoutedEventHandler(this.StkEditUser_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cmbUserEmployee = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
            this.cmbUserEmployee.Loaded += new System.Windows.RoutedEventHandler(this.cmbUserEmployee_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 78 "..\..\..\View\SettingsUserEditMiniWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

