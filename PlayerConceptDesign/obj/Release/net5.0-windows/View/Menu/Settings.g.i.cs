﻿#pragma checksum "..\..\..\..\..\View\Menu\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B80785A0D9EB424BE1E8694B651EB11E5DC9BB35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PlayerConceptDesign;
using PlayerConceptDesign.ViewModel;
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


namespace PlayerConceptDesign.View.Menu {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\View\Menu\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelActiveTheme;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\View\Menu\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderAnimationSpeed;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\..\..\View\Menu\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxShowAlbum;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PlayerConceptDesign;component/view/menu/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Menu\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LabelActiveTheme = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 68 "..\..\..\..\..\View\Menu\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 69 "..\..\..\..\..\View\Menu\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 70 "..\..\..\..\..\View\Menu\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 71 "..\..\..\..\..\View\Menu\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 72 "..\..\..\..\..\View\Menu\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SliderAnimationSpeed = ((System.Windows.Controls.Slider)(target));
            
            #line 112 "..\..\..\..\..\View\Menu\Settings.xaml"
            this.SliderAnimationSpeed.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderAnimationSpeed_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CheckBoxShowAlbum = ((System.Windows.Controls.CheckBox)(target));
            
            #line 210 "..\..\..\..\..\View\Menu\Settings.xaml"
            this.CheckBoxShowAlbum.Click += new System.Windows.RoutedEventHandler(this.CheckBoxShowAlbumClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
