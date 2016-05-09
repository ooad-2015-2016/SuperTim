using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.Models
{
    class Liga
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String NazivLige { get; set; }
        public List<Delegat> Delegati { get; set; }
        public List<Tim> Timovi { get; set; }
        public RasporedUtakmice UtakmiceRaspored { get; set; }


    }
}
