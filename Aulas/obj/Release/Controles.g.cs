﻿#pragma checksum "..\..\Controles.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07F1B11592E123C7B4321EE1310B52ADF8B9F4FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Aulas;
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


namespace Aulas {
    
    
    /// <summary>
    /// Controles
    /// </summary>
    public partial class Controles : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Entrada;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Limpar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Resultado;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Vermelho;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Verde;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Azul;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sair;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ResultadoMessageBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Controles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Paises;
        
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
            System.Uri resourceLocater = new System.Uri("/Aulas;component/controles.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Controles.xaml"
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
            
            #line 8 "..\..\Controles.xaml"
            ((Aulas.Controles)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Entrada = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\Controles.xaml"
            this.Entrada.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Entrada_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Limpar = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Controles.xaml"
            this.Limpar.Click += new System.Windows.RoutedEventHandler(this.Limpar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Resultado = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Vermelho = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\Controles.xaml"
            this.Vermelho.Checked += new System.Windows.RoutedEventHandler(this.Vermelho_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Verde = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\Controles.xaml"
            this.Verde.Checked += new System.Windows.RoutedEventHandler(this.Verde_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Azul = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\Controles.xaml"
            this.Azul.Checked += new System.Windows.RoutedEventHandler(this.Azul_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Sair = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Controles.xaml"
            this.Sair.Click += new System.Windows.RoutedEventHandler(this.Sair_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ResultadoMessageBox = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Paises = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\Controles.xaml"
            this.Paises.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Paises_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

