﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "641687C7DE020461171522D1C33E2AC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace editor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gr;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas cnv;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it3;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it4;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it5;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it6;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl it7;
        
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
            System.Uri resourceLocater = new System.Uri("/editor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 4 "..\..\MainWindow.xaml"
            ((editor.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gr = ((System.Windows.Controls.Grid)(target));
            
            #line 5 "..\..\MainWindow.xaml"
            this.gr.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cnv = ((System.Windows.Controls.InkCanvas)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.cnv.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cnv_MouseDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.cnv.KeyDown += new System.Windows.Input.KeyEventHandler(this.cnv_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_14);
            
            #line default
            #line hidden
            return;
            case 5:
            this.list = ((System.Windows.Controls.ListBox)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.list.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.list.MouseEnter += new System.Windows.Input.MouseEventHandler(this.list_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.list.MouseMove += new System.Windows.Input.MouseEventHandler(this.list_MouseMove);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.list.MouseLeave += new System.Windows.Input.MouseEventHandler(this.list_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.it1 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.it1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 7:
            this.it2 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.it2.StylusEnter += new System.Windows.Input.StylusEventHandler(this.ItemsControl_StylusEnter);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.it2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.it2_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.it3 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.it3.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.it4 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.it4.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter_2);
            
            #line default
            #line hidden
            return;
            case 10:
            this.it5 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.it5.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter_3);
            
            #line default
            #line hidden
            return;
            case 11:
            this.it6 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.it6.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter_4);
            
            #line default
            #line hidden
            return;
            case 12:
            this.it7 = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.it7.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ItemsControl_MouseEnter_5);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 46 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 51 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_9);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 57 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_11);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_12);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_13);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
