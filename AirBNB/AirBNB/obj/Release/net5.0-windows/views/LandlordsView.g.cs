﻿#pragma checksum "..\..\..\..\views\LandlordsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "558A3F4346CE2CA58BBA5BCC5763CB0AFA24A541"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AirBNB.Viewmodels;
using AirBNB.views;
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


namespace AirBNB.views {
    
    
    /// <summary>
    /// LandlordsView
    /// </summary>
    public partial class LandlordsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_landlord;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_landlord;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LandlordsListview;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button View_Landlord;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Firstname;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_lastname;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Locations;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\views\LandlordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AirBNB.views.ViewIndividualLandlord TheHiddenViewer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AirBNB;component/views/landlordsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\LandlordsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Delete_landlord = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.Add_landlord = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.LandlordsListview = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.View_Landlord = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\views\LandlordsView.xaml"
            this.View_Landlord.Click += new System.Windows.RoutedEventHandler(this.View_Landlord_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Textbox_Firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Textbox_lastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Textbox_Locations = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TheHiddenViewer = ((AirBNB.views.ViewIndividualLandlord)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

