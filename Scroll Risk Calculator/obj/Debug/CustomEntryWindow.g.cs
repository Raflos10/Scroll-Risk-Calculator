﻿#pragma checksum "..\..\CustomEntryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBFB0D36E188B35E38E255491B5A6E05D143ECD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Scroll_Risk_Calculator;
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


namespace Scroll_Risk_Calculator {
    
    
    /// <summary>
    /// CustomEntryWindow
    /// </summary>
    public partial class CustomEntryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\CustomEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Success_Chance_TextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CustomEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Destroy_Chance_TextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CustomEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel_Button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CustomEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/Scroll Risk Calculator;component/customentrywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomEntryWindow.xaml"
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
            this.Success_Chance_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\CustomEntryWindow.xaml"
            this.Success_Chance_TextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Success_Chance_TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 18 "..\..\CustomEntryWindow.xaml"
            this.Success_Chance_TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.Success_Chance_TextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 18 "..\..\CustomEntryWindow.xaml"
            this.Success_Chance_TextBox.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.Success_Chance_TextBox_Pasting));
            
            #line default
            #line hidden
            return;
            case 2:
            this.Destroy_Chance_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\CustomEntryWindow.xaml"
            this.Destroy_Chance_TextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Destroy_Chance_TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 23 "..\..\CustomEntryWindow.xaml"
            this.Destroy_Chance_TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.Destroy_Chance_TextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\CustomEntryWindow.xaml"
            this.Destroy_Chance_TextBox.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.Destroy_Chance_TextBox_Pasting));
            
            #line default
            #line hidden
            return;
            case 3:
            this.Cancel_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\CustomEntryWindow.xaml"
            this.Cancel_Button.Click += new System.Windows.RoutedEventHandler(this.Cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OK_Button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\CustomEntryWindow.xaml"
            this.OK_Button.Click += new System.Windows.RoutedEventHandler(this.OK_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
