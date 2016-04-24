using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.TrenerBaza.Models
{
    class Delegat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DelegatId { get; set; }
        public string fourSqaureId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Datum { get; set; }
        public byte[] Slika { get; set; }
    }
}
