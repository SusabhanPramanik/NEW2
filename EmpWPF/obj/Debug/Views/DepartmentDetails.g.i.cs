﻿#pragma checksum "..\..\..\Views\DepartmentDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5CCF8725617D51969053556AD0986F1D2EE616E042509EAF3B3F112E6507A837"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EmpWPF.ViewModels;
using EmpWPF.Views;
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


namespace EmpWPF.Views {
    
    
    /// <summary>
    /// DepartmentDetails
    /// </summary>
    public partial class DepartmentDetails : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxID;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDepID;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDepName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNew;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\DepartmentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDepartment;
        
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
            System.Uri resourceLocater = new System.Uri("/EmpWPF;component/views/departmentdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DepartmentDetails.xaml"
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
            this.TextBoxID = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\Views\DepartmentDetails.xaml"
            this.TextBoxID.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxDepID = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Views\DepartmentDetails.xaml"
            this.TextBoxDepID.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbDepName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Views\DepartmentDetails.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Clicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonNew = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.dgDepartment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 79 "..\..\..\Views\DepartmentDetails.xaml"
            this.dgDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Dgdepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

