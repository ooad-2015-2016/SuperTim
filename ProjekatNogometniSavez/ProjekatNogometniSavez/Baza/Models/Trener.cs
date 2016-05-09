using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.Models
{
    class Trener
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrenerId { get; set; }//primary key u bazi
        public string fourSqaureId { get; set; }//trebati ce za sihronizaciju kasnije
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Datum { get; set; }
        public byte[] Slika { get; set; }
    }
}
