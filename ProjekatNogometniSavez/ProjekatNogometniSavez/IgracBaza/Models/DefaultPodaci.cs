using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.IgracBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(IgracDbContext context)
        {
            if (!context.Igraci.Any())
            {
                context.Igraci.AddRange(
                new Igrac()
                {
                    Ime = "Edin",
                    Prezime = "Dzeko",
                    datumRodjenja = new DateTime(1986, 3, 17),
                    golovi = 0,
                    zuti = 0,
                    crveni = 0,
                    podSuspenzijom = false,
                    brojUtakmicaZaSuspenziju = 0,
                    brojOdigranihUtakmica = 0
                }
                );
                context.SaveChanges();
            }
        }
    }
}
   
