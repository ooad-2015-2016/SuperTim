using ProjekatNogometniSavez.Baza.Models;
using ProjekatNogometniSavez.Baza.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.DataSource
{
    //Klasa koja predstavlja sloj podataka
    public class DataSourceMenuMD
    {
        #region Korisnik - kreiranje testnih korisnika
        private static List<Korisnik> _korisnici = new List<Korisnik>()
 {
 new Korisnik()
 {
 KorisnikId=1,
 KorisnickoIme="admin",
 Sifra="admin",
 },
 new Korisnik()
 {
 KorisnikId=3,
 KorisnickoIme="trener",
 Sifra="trener"
 },
 new Korisnik()
 {
 KorisnikId=2,
 KorisnickoIme="delegat",
 Sifra="delegat"
 },
 new Korisnik()
 {
 KorisnikId=4,
 KorisnickoIme="",
 Sifra=""
 }
 };
        public static IList<Korisnik> DajSveKorisnike()
        {
            return _korisnici;
        }
        public static Korisnik DajKorisnikaPoId(int korisnikId)
        {
            return _korisnici.Where(k => k.KorisnikId.Equals(korisnikId)).FirstOrDefault();
        }
        public static Korisnik ProvjeraKorisnika(string korisnickoIme, string sifra)
        {
            Korisnik rezultat = new Korisnik();
            foreach (var k in DajSveKorisnike())
            {
                if (k.KorisnickoIme == korisnickoIme && k.Sifra == sifra) rezultat = k;
            }
            return rezultat;
        }
        #endregion
        #region Uloga - kreiranje testnih uloga
        private static List<Uloga> _uloge = new List<Uloga>()
 {
 new Uloga()
 {
 UlogaId=1,
Naziv="Administrator",
 },
 new Uloga()
 {
 UlogaId=2,
 Naziv="Delegat",
 },
 new Uloga()
 {
 UlogaId=3,
 Naziv="Trener",
 },
 new Uloga()
 {
 UlogaId=4,
 Naziv="Gost",
 }
 };
        public static IList<Uloga> DajSveUloge()
        {
            return _uloge;
        }
        public static Uloga DajUloguPoId(int ulogaId)
        {
            return _uloge.Where(k => k.UlogaId.Equals(ulogaId)).FirstOrDefault();
        }
        #endregion
        #region MeniStavka - kreiranje novih meni stavki
        private static List<MeniStavka> _meniStavke = new List<MeniStavka>()
 {
 new MeniStavka()
 {
 MeniStavkaId=1,
Naziv="Liga",
Kod="F1",
Podstranica = typeof(TreneriListView)
 },
 new MeniStavka()
 {
 MeniStavkaId=2,
Naziv="Delegat",
 Kod="F2",
 Podstranica = typeof(TreneriListView)
 },
 new MeniStavka()
 {
 MeniStavkaId=3,
Naziv="Trener",
Kod="F3",
 Podstranica = typeof(TreneriListView)
 },
 new MeniStavka()
 {
 MeniStavkaId=4,
Naziv="Raspored utakmica",
Kod="F4",
Podstranica = typeof(TreneriListView)
 },
 };
        public static IList<MeniStavka> DajSveMeniStavke()
        {
            return _meniStavke;
        }
        public static MeniStavka DajMeniStavkuPoId(int meniStavkaId)
        {
            return _meniStavke.Where(k => k.MeniStavkaId.Equals(meniStavkaId)).FirstOrDefault();
        }
        #endregion
        #region Inicijalna postavka uloga i stavki
        public DataSourceMenuMD()
        {
            Korisnik k1 = DajKorisnikaPoId(1);
            Korisnik k2 = DajKorisnikaPoId(2);
            Korisnik k3 = DajKorisnikaPoId(3);
            Korisnik k4 = DajKorisnikaPoId(4);
            Uloga u1 = DajUloguPoId(1);
            Uloga u2 = DajUloguPoId(2);
            Uloga u3 = DajUloguPoId(3);
            Uloga u4 = DajUloguPoId(4);
            MeniStavka ms1 = DajMeniStavkuPoId(1);
            MeniStavka ms2 = DajMeniStavkuPoId(2);
            MeniStavka ms3 = DajMeniStavkuPoId(3);
            MeniStavka ms4 = DajMeniStavkuPoId(4);
            //admin
            u1.DodajMeniStavkuUlozi(ms1);
            u1.DodajMeniStavkuUlozi(ms2);
            u1.DodajMeniStavkuUlozi(ms3);
            u1.DodajMeniStavkuUlozi(ms4);
            k1.DodajUloguKorisnika(u1);
            // delegat
            u2.DodajMeniStavkuUlozi(ms2);
            k2.DodajUloguKorisnika(u2);
            //trener
            u3.DodajMeniStavkuUlozi(ms3);
            k3.DodajUloguKorisnika(u3);
            //gost
            u4.DodajMeniStavkuUlozi(ms4);
            k4.DodajUloguKorisnika(u4);
        }
        #endregion
    }
}


