using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatNogometniSavez.Baza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(BazaDbContext context)
        {
            if (!context.Treneri.Any())
            {
                context.Treneri.AddRange(
                new Trener()
                {
                    Ime = "Mehmed",
                    Prezime = "Baždarevic",
                    Datum = 28091960,
                    //Slika = Convert.FromBase64String(@"mehmed-bazdarevic-bih_fx0odqm1xuoa1jr7t0udelcmw")

                }
                );
                context.SaveChanges();
            }
        }

    }
}
