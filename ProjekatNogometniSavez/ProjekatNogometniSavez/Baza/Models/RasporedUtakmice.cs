using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjekatNogometniSavez.Baza.Models
{
    public class RasporedUtakmice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RasporedUtakmiceId { get; set; }
        public string fourSqaureId { get; set; }
        public List<Utakmica> ListaUtamica { get; set; }

    }
}