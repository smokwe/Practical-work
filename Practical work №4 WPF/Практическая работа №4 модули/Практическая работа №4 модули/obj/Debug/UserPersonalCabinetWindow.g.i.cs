﻿#pragma checksum "..\..\UserPersonalCabinetWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E951939992D751378401C86F62713483CA1B1DDC3055524F8E8BC69D9104068"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Практическая_работа__4_модули;


namespace Практическая_работа__4_модули {
    
    
    /// <summary>
    /// UserPersonalCabinetWindow
    /// </summary>
    public partial class UserPersonalCabinetWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WelcomeMessage;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookTitleInput;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookAuthorInput;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBookButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox BooksList;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\UserPersonalCabinetWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveBookButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Практическая работа №4 модули;component/userpersonalcabinetwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserPersonalCabinetWindow.xaml"
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
            this.WelcomeMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BookTitleInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BookAuthorInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\UserPersonalCabinetWindow.xaml"
            this.AddBookButton.Click += new System.Windows.RoutedEventHandler(this.AddBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BooksList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.RemoveBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\UserPersonalCabinetWindow.xaml"
            this.RemoveBookButton.Click += new System.Windows.RoutedEventHandler(this.RemoveBookButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

