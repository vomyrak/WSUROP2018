<<<<<<< HEAD
﻿#pragma checksum "..\..\..\UserControls\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5D18182EB535A3E505DA9FE20918B159D97A46BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UCUI.UserControls;


namespace UCUI.UserControls {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BindGrid;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SidebarGrid;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SettingsBlock;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AudioButton;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CenterMouse;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShakeButton;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ThemeBox;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HoverButton;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FullScreenButton;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TimerBox;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UCUI;component/usercontrols/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\SettingsView.xaml"
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
            this.BindGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 133 "..\..\..\UserControls\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SidebarGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.SettingsBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AudioButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.CenterMouse = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.ShakeButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.ThemeBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 194 "..\..\..\UserControls\SettingsView.xaml"
            this.ThemeBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 195 "..\..\..\UserControls\SettingsView.xaml"
            this.ThemeBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ComboBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HoverButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.FullScreenButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.TimerBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 223 "..\..\..\UserControls\SettingsView.xaml"
            this.TimerBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 224 "..\..\..\UserControls\SettingsView.xaml"
            this.TimerBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ComboBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 242 "..\..\..\UserControls\SettingsView.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 251 "..\..\..\UserControls\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

=======
﻿#pragma checksum "..\..\..\UserControls\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37C7878BC228F742CB26B7066FB0C7EFF7B35858"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UCUI.UserControls;


namespace UCUI.UserControls {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BindGrid;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SidebarGrid;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SettingsBlock;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AudioButton;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CenterMouse;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShakeButton;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TimerBox;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HoverButton;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FullScreenButton;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ThemeBox;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\UserControls\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UCUI;component/usercontrols/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\SettingsView.xaml"
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
            this.BindGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 133 "..\..\..\UserControls\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SidebarGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.SettingsBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AudioButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.CenterMouse = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.ShakeButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.TimerBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 194 "..\..\..\UserControls\SettingsView.xaml"
            this.TimerBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 195 "..\..\..\UserControls\SettingsView.xaml"
            this.TimerBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ComboBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HoverButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.FullScreenButton = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.ThemeBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 223 "..\..\..\UserControls\SettingsView.xaml"
            this.ThemeBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 224 "..\..\..\UserControls\SettingsView.xaml"
            this.ThemeBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ComboBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 240 "..\..\..\UserControls\SettingsView.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 249 "..\..\..\UserControls\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

>>>>>>> prototype_balint
