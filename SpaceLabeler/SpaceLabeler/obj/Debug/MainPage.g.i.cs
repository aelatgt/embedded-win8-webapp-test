﻿#pragma checksum "C:\Users\Varun\Desktop\SpaceLabeler\SpaceLabeler\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C6F41D90DB583D65250E02EE529F215E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SpaceLabeler {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.VideoBrush videoBrush;
        
        internal System.Windows.Controls.Canvas TextBoxCanvas;
        
        internal System.Windows.Controls.TextBox txtName;
        
        internal System.Windows.Controls.Button gobutton;
        
        internal System.Windows.Controls.TextBox searchbar;
        
        internal Microsoft.Phone.Controls.WebBrowser webBrowser1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SpaceLabeler;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.videoBrush = ((System.Windows.Media.VideoBrush)(this.FindName("videoBrush")));
            this.TextBoxCanvas = ((System.Windows.Controls.Canvas)(this.FindName("TextBoxCanvas")));
            this.txtName = ((System.Windows.Controls.TextBox)(this.FindName("txtName")));
            this.gobutton = ((System.Windows.Controls.Button)(this.FindName("gobutton")));
            this.searchbar = ((System.Windows.Controls.TextBox)(this.FindName("searchbar")));
            this.webBrowser1 = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("webBrowser1")));
        }
    }
}
