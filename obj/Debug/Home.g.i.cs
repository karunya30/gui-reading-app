﻿#pragma checksum "..\..\Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE71751A64BD1E8417D8818F857C254A4F526F235EEBB0E1FA12F4176707E9DB"
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
using WpfFunReader;


namespace WpfFunReader {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reading;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_subscribe;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_transcribe;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Speech_Settings;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Connect_Motioninput;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfFunReader;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
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
            this.btn_reading = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Home.xaml"
            this.btn_reading.Click += new System.Windows.RoutedEventHandler(this.btn_reading_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_subscribe = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Home.xaml"
            this.btn_subscribe.Click += new System.Windows.RoutedEventHandler(this.btn_subscribe_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_transcribe = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Home.xaml"
            this.btn_transcribe.Click += new System.Windows.RoutedEventHandler(this.btn_transcribe_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Speech_Settings = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Home.xaml"
            this.Speech_Settings.Click += new System.Windows.RoutedEventHandler(this.Speech_Settings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Connect_Motioninput = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Home.xaml"
            this.Connect_Motioninput.Click += new System.Windows.RoutedEventHandler(this.Connect_Motioninput_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

