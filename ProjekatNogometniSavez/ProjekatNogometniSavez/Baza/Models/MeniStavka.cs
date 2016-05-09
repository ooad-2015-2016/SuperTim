using System;
using System.Collections.Generic;

namespace ProjekatNogometniSavez.Baza.Models
{
    public class MeniStavka
    {
        public int MeniStavkaId { get; set; }
        public string Naziv { get; set; }
        public string Kod { get; set; }
        public Type Podstranica { get; set; } //Koristi se kao Navigacija ka stavci menija odnosno podstranici koju otvara
                                              //Dio modela predviđen za nadogradnju sa EntityFramework-om
        public virtual ICollection<UlogaMeniStavka> UlogaMeniStavke
        {
            get;
            set;
        }
    }
}