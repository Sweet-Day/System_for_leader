﻿#pragma checksum "..\..\..\Views\AboutCertificateView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C28458152C2653430DC7BE9B716FD913BF67A27094739A63EC55ECB396E86542"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using GroupManager.Views;
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


namespace GroupManager.Views {
    
    
    /// <summary>
    /// AboutCertificateView
    /// </summary>
    public partial class AboutCertificateView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AvatarImage;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadAvatar;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveStudent;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenEditMode;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\Views\AboutCertificateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateCertificate;
        
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
            System.Uri resourceLocater = new System.Uri("/GroupManager;component/views/aboutcertificateview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AboutCertificateView.xaml"
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
            
            #line 10 "..\..\..\Views\AboutCertificateView.xaml"
            ((GroupManager.Views.AboutCertificateView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.AvatarImage = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.UploadAvatar = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.SaveStudent = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.OpenEditMode = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.DateCertificate = ((System.Windows.Controls.TextBox)(target));
            
            #line 179 "..\..\..\Views\AboutCertificateView.xaml"
            this.DateCertificate.LostFocus += new System.Windows.RoutedEventHandler(this.DateCertificate_LostFocus);
            
            #line default
            #line hidden
            
            #line 179 "..\..\..\Views\AboutCertificateView.xaml"
            this.DateCertificate.GotFocus += new System.Windows.RoutedEventHandler(this.DateCertificate_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

