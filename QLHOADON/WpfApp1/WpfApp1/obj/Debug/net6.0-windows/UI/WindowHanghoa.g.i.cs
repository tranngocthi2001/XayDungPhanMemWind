﻿#pragma checksum "..\..\..\..\UI\WindowHanghoa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74D1EF5C8C7E9C9D464A7C1099481D3BFFC5AF93"
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
using WpfApp1.ModelVM;
using WpfApp1.UI;


namespace WpfApp1.UI {
    
    
    /// <summary>
    /// WindowHanghoa
    /// </summary>
    public partial class WindowHanghoa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\UI\WindowHanghoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding lenhThem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\WindowHanghoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding lenhXoa;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\UI\WindowHanghoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridHanghoa;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\UI\WindowHanghoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHanghoa;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/ui/windowhanghoa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\WindowHanghoa.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\UI\WindowHanghoa.xaml"
            ((WpfApp1.UI.WindowHanghoa)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lenhThem = ((System.Windows.Input.CommandBinding)(target));
            
            #line 13 "..\..\..\..\UI\WindowHanghoa.xaml"
            this.lenhThem.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.lenhThem_Executed);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\UI\WindowHanghoa.xaml"
            this.lenhThem.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.lenhThem_CanExecute);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lenhXoa = ((System.Windows.Input.CommandBinding)(target));
            
            #line 15 "..\..\..\..\UI\WindowHanghoa.xaml"
            this.lenhXoa.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.lenhXoa_Executed);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\UI\WindowHanghoa.xaml"
            this.lenhXoa.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.lenhXoa_CanExecute);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridHanghoa = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.dgHanghoa = ((System.Windows.Controls.DataGrid)(target));
            
            #line 50 "..\..\..\..\UI\WindowHanghoa.xaml"
            this.dgHanghoa.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dgHanghoa_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

