﻿#pragma checksum "C:\Users\Varun\Documents\GitHub\argon-win8\SpaceLabeler\SpaceLabeler\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2CACBB05D4B1A82FF6D875C4F97C2F8B"
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
using SpaceLabeler;
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
    
    
    public partial class MainPage : SpaceLabeler.MyCustomePage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.VideoBrush videoBrush;
        
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
            this.gobutton = ((System.Windows.Controls.Button)(this.FindName("gobutton")));
            this.searchbar = ((System.Windows.Controls.TextBox)(this.FindName("searchbar")));
            this.webBrowser1 = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("webBrowser1")));
        }
    }
}

