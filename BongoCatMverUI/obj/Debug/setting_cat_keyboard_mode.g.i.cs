﻿#pragma checksum "..\..\setting_cat_keyboard_mode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EC4DCF1B0E6F3B1B05ABB67E4C8E36C381235501F176974DF95CDA03E390D49"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MyWpfApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MyWpfApp {
    
    
    /// <summary>
    /// setting_cat_keyboard_mode
    /// </summary>
    public partial class setting_cat_keyboard_mode : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 123 "..\..\setting_cat_keyboard_mode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox is_Using_live2d_check;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\setting_cat_keyboard_mode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\setting_cat_keyboard_mode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gird_l2d_horizontal_flip;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\setting_cat_keyboard_mode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gird_l2d_correct;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\setting_cat_keyboard_mode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_l2d_correct;
        
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
            System.Uri resourceLocater = new System.Uri("/BongoCatMverUI;component/setting_cat_keyboard_mode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\setting_cat_keyboard_mode.xaml"
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
            this.is_Using_live2d_check = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\setting_cat_keyboard_mode.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_is_Using_live2d_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gird_l2d_horizontal_flip = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.gird_l2d_correct = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.textbox_l2d_correct = ((System.Windows.Controls.TextBox)(target));
            
            #line 213 "..\..\setting_cat_keyboard_mode.xaml"
            this.textbox_l2d_correct.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_Num_limite);
            
            #line default
            #line hidden
            
            #line 214 "..\..\setting_cat_keyboard_mode.xaml"
            this.textbox_l2d_correct.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

