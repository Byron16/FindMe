﻿#pragma checksum "D:\3Wb216\Documents\Visual Studio 2013\Projects\FindMe App\FindMe App\rasgos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3D55E90AD60351E7E8238FE1478941C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace FindMe_App {
    
    
    public partial class rasgos : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txbcoincidencias;
        
        internal System.Windows.Controls.StackPanel stkfoto;
        
        internal System.Windows.Controls.Image imagen;
        
        internal System.Windows.Controls.Button btngaleria;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnenviar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FindMe%20App;component/rasgos.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txbcoincidencias = ((System.Windows.Controls.TextBlock)(this.FindName("txbcoincidencias")));
            this.stkfoto = ((System.Windows.Controls.StackPanel)(this.FindName("stkfoto")));
            this.imagen = ((System.Windows.Controls.Image)(this.FindName("imagen")));
            this.btngaleria = ((System.Windows.Controls.Button)(this.FindName("btngaleria")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnenviar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnenviar")));
        }
    }
}

