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
    partial class MainPage : Windows.UI.Xaml.Controls.Page, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 12 "..\..\MainPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TakePhoto;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 15 "..\..\MainPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Testing;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 37 "..\..\MainPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.UploadImage;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


