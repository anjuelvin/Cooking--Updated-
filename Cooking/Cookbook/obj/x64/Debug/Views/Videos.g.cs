﻿#pragma checksum "E:\Anju\Documents\C# Adv\Project\Cooking\Cooking\Cookbook\Views\Videos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "96570AD8FD9C2240DAB02D176CAE7078"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookbook.Views
{
    partial class Videos : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.bottomCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 12 "..\..\..\Views\Videos.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.VideosButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 13 "..\..\..\Views\Videos.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.CategoriesButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element4 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 14 "..\..\..\Views\Videos.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element4).Click += this.RecipesButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.RootPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 7:
                {
                    this.VideoView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 8:
                {
                    this.VideoView1 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 9:
                {
                    this.VideoView2 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 10:
                {
                    this.VideoView3 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 11:
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

