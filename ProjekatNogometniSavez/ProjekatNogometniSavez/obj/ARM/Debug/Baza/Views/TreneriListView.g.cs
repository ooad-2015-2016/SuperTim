﻿#pragma checksum "C:\Users\selsebil\Desktop\SuperTim\ProjekatNogometniSavez\ProjekatNogometniSavez\Baza\Views\TreneriListView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB088EA6F3A8310EFA0B41D137ED5228"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatNogometniSavez.Baza.Views
{
    partial class TreneriListView : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\..\Baza\Views\TreneriListView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.ImeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.ImeInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.PrezimeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.PrezimeInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.DatumTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.DatumInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.SlikaLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.buttonUpload = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\..\Baza\Views\TreneriListView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonUpload).Click += this.buttonUpload_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.buttonDodaj = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\..\Baza\Views\TreneriListView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonDodaj).Click += this.buttonDodaj_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.TreneriIS = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\..\Baza\Views\TreneriListView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Button_Click_Delete;
                    #line default
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

