﻿#pragma checksum "..\..\..\Windows\wMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC8BE2361AF20A0679123A6DB45FF1E0000A3B0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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


namespace PurgePrinterQueue.Windows {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRefresh;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miPurge;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miInfo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spJobs;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cnStatus;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroProgressBar mpProgress;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\wMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/PurgePrinterQueue;component/windows/wmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\wMain.xaml"
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
            this.miRefresh = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\Windows\wMain.xaml"
            this.miRefresh.Click += new System.Windows.RoutedEventHandler(this.miRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miPurge = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\Windows\wMain.xaml"
            this.miPurge.Click += new System.Windows.RoutedEventHandler(this.miPurge_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.miInfo = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\Windows\wMain.xaml"
            this.miInfo.Click += new System.Windows.RoutedEventHandler(this.miInfo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.spJobs = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.cnStatus = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.mpProgress = ((MahApps.Metro.Controls.MetroProgressBar)(target));
            return;
            case 7:
            this.lblStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

