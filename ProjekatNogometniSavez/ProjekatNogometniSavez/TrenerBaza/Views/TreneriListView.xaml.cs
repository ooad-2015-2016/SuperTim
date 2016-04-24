using ProjekatNogometniSavez.TrenerBaza.Models;
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

namespace ProjekatNogometniSavez.TrenerBaza.Views
{
   
        public sealed partial class TreneriListView : Page
        {
            //Potrebno je privremeno negdje staviti sliku koja se uploaduje
            private byte[] uploadSlika;
            public TreneriListView()
            {
                this.InitializeComponent();
            }
           
            private void Page_Loaded(object sender, RoutedEventArgs e)
            {
                using (var db = new TrenerDbContext())
                {
                    TreneriIS.ItemsSource = db.Treneri.OrderBy(c => c.Ime).ToList();
                }
            }
            //Event dodavanja novog trenera
            private void buttonDodaj_Click(object sender, RoutedEventArgs e)
            {
                using (var db = new TrenerDbContext())
                {
                    var contact = new Trener
                    {
                        Ime = ImeInput.Text,
                        Prezime = PrezimeInput.Text,
                        
                        Datum = Convert.ToInt32(DatumInput.Text),
                        
                        Slika = uploadSlika
                    };
                    db.Treneri.Add(contact);
                    
                db.SaveChanges();
                    //reset polja za unos
                    ImeInput.Text = string.Empty;
                    PrezimeInput.Text = string.Empty;
                    
                    DatumInput.Text = string.Empty;
                    
                    //refresh liste trenera
                    TreneriIS.ItemsSource = db.Treneri.OrderBy(c => c.Ime).ToList();
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
                using (var db = new TrenerDbContext())
                {
                    db.Treneri.Remove((Trener)TreneriIS.ItemFromContainer(dep));
                    //Nije jos obrisano dok nije Save
                    db.SaveChanges();
                    //Refresh liste restorana
                    TreneriIS.ItemsSource = db.Treneri.OrderBy(c => c.Ime).ToList();
                }
            }
           
            
        }

    }

