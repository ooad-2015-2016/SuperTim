using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.Models
{
   public class Liga
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LigaId { get; set; }
        public string fourSqaureId { get; set; }
        public String NazivLige { get; set; }
        public List<Delegat> Delegati { get; set; }
        public List<Tim> Timovi { get; set; }
        public RasporedUtakmice UtakmiceRaspored { get; set; }


    }
}
