﻿#pragma checksum "..\..\Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D6754DB0EFF7A55E0508FA0F29B24B8C6F0DE69"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BibliotecaView;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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


namespace BibliotecaView {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgridveruser;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutingreso;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroTabControl tabprincipal;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcoduser;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnomuser;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcontrasenauser;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxtipouser;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcodmodiuser;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnommodiuser;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcontrasenamodiuser;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxcatemodiuser;
        
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
            System.Uri resourceLocater = new System.Uri("/BibliotecaView;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin.xaml"
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
            
            #line 34 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btnflyout);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 35 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnlogoutadmin);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btndgridusuario);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgridveruser = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.flyoutingreso = ((MahApps.Metro.Controls.Flyout)(target));
            return;
            case 6:
            this.tabprincipal = ((MahApps.Metro.Controls.MetroTabControl)(target));
            return;
            case 7:
            this.txtcoduser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtnomuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtcontrasenauser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.cboxtipouser = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            
            #line 70 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ingresaruser);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtcodmodiuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtnommodiuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.txtcontrasenamodiuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.cboxcatemodiuser = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            
            #line 88 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnmodiuser);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
