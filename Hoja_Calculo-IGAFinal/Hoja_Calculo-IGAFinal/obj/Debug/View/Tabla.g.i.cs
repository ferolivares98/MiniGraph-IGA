﻿#pragma checksum "..\..\..\View\Tabla.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "080F8437DAE13DE189E20D05FFB4B8C6B3F53FEDB4F6A18CA6E926E2279D299E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Hoja_Calculo_IGUFinal;
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


namespace Hoja_Calculo_IGUFinal {
    
    
    /// <summary>
    /// Tabla
    /// </summary>
    public partial class Tabla : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Tabs;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Coord;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textEjeX;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textEjeY;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Elim;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mod;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GrafPunto;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GrafBarra;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView tablaPuntos;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\Tabla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Poli;
        
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
            System.Uri resourceLocater = new System.Uri("/Hoja_Calculo-IGAFinal;component/view/tabla.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Tabla.xaml"
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
            this.Tabs = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.Coord = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.textEjeX = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\View\Tabla.xaml"
            this.textEjeX.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextEjes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textEjeY = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\View\Tabla.xaml"
            this.textEjeY.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextEjes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\View\Tabla.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Elim = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\Tabla.xaml"
            this.Elim.Click += new System.Windows.RoutedEventHandler(this.Elim_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Mod = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\Tabla.xaml"
            this.Mod.Click += new System.Windows.RoutedEventHandler(this.Mod_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GrafPunto = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\Tabla.xaml"
            this.GrafPunto.Click += new System.Windows.RoutedEventHandler(this.GrafPuntos_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GrafBarra = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\Tabla.xaml"
            this.GrafBarra.Click += new System.Windows.RoutedEventHandler(this.GrafBarras_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tablaPuntos = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.Poli = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

