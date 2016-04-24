using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.IgracBaza.Models
{
    class Igrac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IgracId { get; set; }//primary key u bazi
        public string fourSqaureId { get; set; }//trebati ce za sihronizaciju kasnije
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int golovi { get; set; }
        public int zuti { get; set; }
        public int crveni { get; set; }
        public bool podSuspenzijom { get; set; }
        public int brojUtakmicaZaSuspenziju { get; set; }
        public int brojOdigranihUtakmica { get; set; }
    }
}
