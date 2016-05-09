using System.ComponentModel.DataAnnotations.Schema;

namespace ProjekatNogometniSavez.Baza.Models
{
    public class Delegat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DelegatId { get; set; }//primary key u bazi
        public string fourSqaureId { get; set; }//trebati ce za sihronizaciju kasnije
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Datum { get; set; }
        public byte[] Slika { get; set; }
    }
}