﻿#pragma checksum "..\..\..\Views\AboutStudentView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9418A150074F40CB3E18EDF066154B13B0DA1EA99FAA5E4B426837433DCE7671"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using GroupManager.Views;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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
    /// AboutStudentView
    /// </summary>
    public partial class AboutStudentView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AvatarImage;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadAvatar;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveStudent;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenAddCertificate;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenEditMode;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateCharacteristic;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl mainTab;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton AddStudentParents;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ParentsForm;
        
        #line default
        #line hidden
        
        
        #line 343 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton AddPrivelegesButton;
        
        #line default
        #line hidden
        
        
        #line 352 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PrivilegesForm;
        
        #line default
        #line hidden
        
        
        #line 502 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StudentsList;
        
        #line default
        #line hidden
        
        
        #line 565 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoveToPrevious;
        
        #line default
        #line hidden
        
        
        #line 576 "..\..\..\Views\AboutStudentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoveToNext;
        
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
            System.Uri resourceLocater = new System.Uri("/GroupManager;component/views/aboutstudentview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AboutStudentView.xaml"
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
            this.Back = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.AvatarImage = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.UploadAvatar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.SaveStudent = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.OpenAddCertificate = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.OpenEditMode = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.CreateCharacteristic = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.mainTab = ((System.Windows.Controls.TabControl)(target));
            
            #line 193 "..\..\..\Views\AboutStudentView.xaml"
            this.mainTab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddStudentParents = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 10:
            this.ParentsForm = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            
            #line 276 "..\..\..\Views\AboutStudentView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddParent_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AddPrivelegesButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 13:
            this.PrivilegesForm = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            
            #line 360 "..\..\..\Views\AboutStudentView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPrivelege_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.StudentsList = ((System.Windows.Controls.ListView)(target));
            
            #line 504 "..\..\..\Views\AboutStudentView.xaml"
            this.StudentsList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.StudentsList_MouseDoubleClick_1);
            
            #line default
            #line hidden
            return;
            case 16:
            this.MoveToPrevious = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.MoveToNext = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

