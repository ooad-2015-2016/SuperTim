using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjekatNogometniSavez.Baza.Models
{
    public class Utakmica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtakmicaId { get; set; }
        public string fourSqaureId { get; set; }
        public string Tim1 { get; set; }
        public string Tim2 { get; set; }
        public DateTime DatumiVrijeme { get; set; }
        public Delegat Delegat { get; set; }
        public int BrojGolovaTim1 { get; set; }
        public int BrojGolovaTim2 { get; set; }
        public List<Igrac> Strijelci { get; set; }
        public int Zuti { get; set; }
        public int crveni { get; set; }
    }
}