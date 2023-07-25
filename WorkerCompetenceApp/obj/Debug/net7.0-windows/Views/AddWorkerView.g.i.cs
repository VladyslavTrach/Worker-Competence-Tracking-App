﻿#pragma checksum "..\..\..\..\Views\AddWorkerView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BAB5631D66750E41EA3F800F20DA55FC4D11BE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace WorkerCompetenceApp.Views {
    
    
    /// <summary>
    /// AddWorkerView
    /// </summary>
    public partial class AddWorkerView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PositionTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SpecializationTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LangTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewWorkerButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\AddWorkerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WorkerCompetenceApp;component/views/addworkerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddWorkerView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PositionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SpecializationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LangTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EmailNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddNewWorkerButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Views\AddWorkerView.xaml"
            this.AddNewWorkerButton.Click += new System.Windows.RoutedEventHandler(this.AddNewWorkerButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\Views\AddWorkerView.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Views\AddWorkerView.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

