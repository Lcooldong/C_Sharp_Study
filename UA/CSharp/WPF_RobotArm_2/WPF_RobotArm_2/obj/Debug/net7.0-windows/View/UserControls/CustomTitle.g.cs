﻿#pragma checksum "..\..\..\..\..\View\UserControls\CustomTitle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF4E055D7446BC4F6CA7032CE5F780D2B3CC84A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_RobotArm_2.View.UserControls;


namespace WPF_RobotArm_2.View.UserControls {
    
    
    /// <summary>
    /// CustomTitle
    /// </summary>
    public partial class CustomTitle : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_icon;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock test_txtblk;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_minimize;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_maximize;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_RobotArm_2;component/view/usercontrols/customtitle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
            ((WPF_RobotArm_2.View.UserControls.CustomTitle)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl_icon = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.test_txtblk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btn_minimize = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
            this.btn_minimize.Click += new System.Windows.RoutedEventHandler(this.Btn_minimize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_maximize = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
            this.btn_maximize.Click += new System.Windows.RoutedEventHandler(this.Btn_maximize_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\View\UserControls\CustomTitle.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.Btn_close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
