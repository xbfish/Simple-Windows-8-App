﻿

#pragma checksum "C:\Users\mingen\Documents\Visual Studio 2012\Projects\SGFoodSnap\SGFoodSnap\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D3FF40FEAB41369760EBD2ECC740A3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace SGFoodSnap
{
    partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.Image CapturedPhoto; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.ListView Gallery; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.TextBox MessageBox; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///MainPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            CapturedPhoto = (Windows.UI.Xaml.Controls.Image)this.FindName("CapturedPhoto");
            Gallery = (Windows.UI.Xaml.Controls.ListView)this.FindName("Gallery");
            MessageBox = (Windows.UI.Xaml.Controls.TextBox)this.FindName("MessageBox");
        }
    }
}



