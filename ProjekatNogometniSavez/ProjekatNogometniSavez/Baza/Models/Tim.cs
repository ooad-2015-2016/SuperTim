using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.Models
{
    public class Tim
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      
        public int TimId { get; set; }
        public string fourSqaureId { get; set; }
        public String NazivTima { get; set; }
        public List<Igrac> SpisakIgraca { get; set; }
        public String TrenerTima { get; set; }
        public int GoloviTima { get; set; }
        public int PrimljeniGolovi { get; set; }
        public int Bodovi { get; set; }
        public int Porazi { get; set; }
        public int Nerjeseno { get; set; }
        public int ZutiKartoni { get; set; }
        public int CrveniKartoni { get; set; }
    }
}
