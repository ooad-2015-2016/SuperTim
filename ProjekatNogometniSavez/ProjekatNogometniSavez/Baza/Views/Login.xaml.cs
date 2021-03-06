﻿using ProjekatNogometniSavez.Baza.DataSource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatNogometniSavez
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {

        public Login()
        {
            this.InitializeComponent();
            //inicijalizacija data source
            var inicijalizacija = new DataSourceMenuMD();
        }
        //asinhrona metoda za provjeru prijave korisnika
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var korisnickoIme = txtUsername.Text;
            var sifra = txtPassword.Password;
            var korisnik = DataSourceMenuMD.ProvjeraKorisnika(korisnickoIme, sifra);
           if (korisnik != null )
            {
                this.Frame.Navigate(typeof(MainPage), korisnik);
            } 
           else
            
            {
                var dialog = new MessageDialog("Pogresnii login podaci!", "Neuspjesna prijava");
               
                await dialog.ShowAsync();
            }
        }

        private void buttonGost_Click(object sender, RoutedEventArgs e)
        {
            var korisnickoIme = txtUsername.Text;
            var sifra = txtPassword.Password;
            var korisnik = DataSourceMenuMD.ProvjeraKorisnika(korisnickoIme, sifra);
            if (korisnik != null)
            {
                this.Frame.Navigate(typeof(MainPage), korisnik);
            }
            
        }
    }
}
