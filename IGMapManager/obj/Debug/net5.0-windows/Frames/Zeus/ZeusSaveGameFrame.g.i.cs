﻿#pragma checksum "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DDD7A54BB905257C228AECD4685829F627C0537F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using IGMapManager.Frames.Zeus;
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


namespace IGMapManager.Frames.Zeus {
    
    
    /// <summary>
    /// ZeusSaveGameFrame
    /// </summary>
    public partial class ZeusSaveGameFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZeusSaveSetPath;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZeusGameDirPath;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZeusSaveSetRepoPath;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZeusRepoDirPath;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZeusSaveProfile;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZeusProfile;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IGMapManager;component/frames/zeus/zeussavegameframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnZeusSaveSetPath = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
            this.BtnZeusSaveSetPath.Click += new System.Windows.RoutedEventHandler(this.BtnZeusSaveSetPath_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtZeusGameDirPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnZeusSaveSetRepoPath = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
            this.BtnZeusSaveSetRepoPath.Click += new System.Windows.RoutedEventHandler(this.BtnZeusSaveSetRepoPath_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtZeusRepoDirPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnZeusSaveProfile = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\Frames\Zeus\ZeusSaveGameFrame.xaml"
            this.BtnZeusSaveProfile.Click += new System.Windows.RoutedEventHandler(this.BtnZeusSaveProfile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtZeusProfile = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

