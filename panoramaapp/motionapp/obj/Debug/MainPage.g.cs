﻿#pragma checksum "C:\Users\Varun\Documents\visual studio 2012\Projects\panoramaapp\motionapp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "52F488AA104EC04E2F54A9403DFBA620"
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


namespace motionapp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.WebBrowser Browser;
        
        internal System.Windows.Controls.TextBlock qLBL;
        
        internal System.Windows.Controls.TextBlock xLBL;
        
        internal System.Windows.Controls.TextBlock yLBL;
        
        internal System.Windows.Controls.TextBlock zLBL;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/motionapp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Browser = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("Browser")));
            this.qLBL = ((System.Windows.Controls.TextBlock)(this.FindName("qLBL")));
            this.xLBL = ((System.Windows.Controls.TextBlock)(this.FindName("xLBL")));
            this.yLBL = ((System.Windows.Controls.TextBlock)(this.FindName("yLBL")));
            this.zLBL = ((System.Windows.Controls.TextBlock)(this.FindName("zLBL")));
        }
    }
}

