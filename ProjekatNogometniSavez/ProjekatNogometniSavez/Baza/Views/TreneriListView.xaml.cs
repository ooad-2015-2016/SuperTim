using ProjekatNogometniSavez.Baza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProjekatNogometniSavez.Baza.Views
{
   
        public sealed partial class TreneriListView : Page
        {
            //Potrebno je privremeno negdje staviti sliku koja se uploaduje
            private byte[] uploadSlika;
        private byte[] uploadSlika_tim;
        public TreneriListView()
            {
                this.InitializeComponent();
            }
           
            private void Page_Loaded(object sender, RoutedEventArgs e)
            {
                using (var db = new BazaDbContext())
                {
                    DelegatiIS.ItemsSource = db.Delegati.OrderBy(c => c.Ime).ToList();
                }
            }
            //Event dodavanja novog delegata
            private void buttonDodaj_Click(object sender, RoutedEventArgs e)
            {
                using (var db = new BazaDbContext())
                {
                    var contact = new Delegat
                    {
                        Ime = ImeInput.Text,
                        Prezime = PrezimeInput.Text,
                        
                        Datum = Convert.ToInt32(DatumInput.Text),
                        
                        Slika = uploadSlika
                    };
                    db.Delegati.Add(contact);
                    
                db.SaveChanges();
                    //reset polja za unos
                    ImeInput.Text = string.Empty;
                    PrezimeInput.Text = string.Empty;
                    
                    DatumInput.Text = string.Empty;
                    
                    //refresh liste trenera
                    DelegatiIS.ItemsSource = db.Treneri.OrderBy(c => c.Ime).ToList();
                }
            }
            //event za upload slike
            private async void buttonUpload_Click(object sender, RoutedEventArgs e)
            {
                FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
                openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation =
               Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                //Da se filtriraju dokumenti u pickeru na slike
                openPicker.FileTypeFilter.Add(".jpg");
                openPicker.FileTypeFilter.Add(".jpeg");
                openPicker.FileTypeFilter.Add(".png");
                //Prebacivanje contenta fajla u uploadSlika varijablu
                StorageFile file = await openPicker.PickSingleFileAsync();
                if (file != null)
                {
                    uploadSlika = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray(); ;
                    //Da se na buttonu vidi neka promjena da je upload uspjesan
                    buttonUpload.Content = "Picked photo: " + file.Name;
                }
            }
            //Event za brisanje trenera
            private void Button_Click_Delete(object sender, RoutedEventArgs e)
            {
                //Dobavljanje objekta iz liste koji je kori[ten da se popuni red u listview
                DependencyObject dep = (DependencyObject)e.OriginalSource;
                while ((dep != null) && !(dep is ListViewItem))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }
                if (dep == null)
                    return;
                using (var db = new BazaDbContext())
                {
                    db.Delegati.Remove((Delegat)DelegatiIS.ItemFromContainer(dep));
                    //Nije jos obrisano dok nije Save
                    db.SaveChanges();
                    //Refresh liste restorana
                    DelegatiIS.ItemsSource = db.Delegati.OrderBy(c => c.Ime).ToList();
                }
            }
        //dodavanje novog tima
        private void buttonDodaj_tim_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new BazaDbContext())
            {
                var contact = new Tim
                {
                    NazivTima = NazivInput_Tim.Text,
                    TrenerTima = TrenerInput_tim.Text,

                    DatumOsnivanja = Convert.ToInt32(DatumInput_tim.Text),

                    Slika = uploadSlika_tim
                };
                db.Timovi.Add(contact);

                db.SaveChanges();
                //reset polja za unos
                NazivInput_Tim.Text = string.Empty;
                TrenerInput_tim.Text = string.Empty;

                DatumInput_tim.Text = string.Empty;

                //refresh liste trenera
                TimoviIS.ItemsSource = db.Timovi.OrderBy(c => c.NazivTima).ToList();
            }

        }
        //dodavanje slike tima
        private async void UploadSlika_tim_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation =
           Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            //Da se filtriraju dokumenti u pickeru na slike
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            //Prebacivanje contenta fajla u uploadSlika varijablu
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                uploadSlika_tim = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray(); ;
                //Da se na buttonu vidi neka promjena da je upload uspjesan
                UploadSlika_tim.Content = "Picked photo: " + file.Name;
            }

        }
        //brisanje tima
        private void Button_Tim_Delete(object sender, RoutedEventArgs e)
        {
            //Dobavljanje objekta iz liste koji je kori[ten da se popuni red u listview
            DependencyObject dep = (DependencyObject)e.OriginalSource;
            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }
            if (dep == null)
                return;
            using (var db = new BazaDbContext())
            {
                db.Timovi.Remove((Tim)DelegatiIS.ItemFromContainer(dep));
                //Nije jos obrisano dok nije Save
                db.SaveChanges();
                //Refresh liste restorana
                TimoviIS.ItemsSource = db.Timovi.OrderBy(c => c.NazivTima).ToList();
            }
        }
    }

    }

