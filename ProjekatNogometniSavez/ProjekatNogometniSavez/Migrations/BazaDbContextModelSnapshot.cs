using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProjekatNogometniSavez.Baza.Models;

namespace ProjekatNogometniSavezMigrations
{
    [ContextType(typeof(BazaDbContext))]
    partial class BazaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Delegat", b =>
                {
                    b.Property<int>("DelegatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Datum");

                    b.Property<string>("Ime");

                    b.Property<int?>("LigaLigaId");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<string>("fourSqaureId");

                    b.Key("DelegatId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Igrac", b =>
                {
                    b.Property<int>("IgracId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int?>("TimTimId");

                    b.Property<int?>("UtakmicaUtakmicaId");

                    b.Property<int>("brojOdigranihUtakmica");

                    b.Property<int>("brojUtakmicaZaSuspenziju");

                    b.Property<int>("crveni");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("fourSqaureId");

                    b.Property<int>("golovi");

                    b.Property<bool>("podSuspenzijom");

                    b.Property<int>("zuti");

                    b.Key("IgracId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Liga", b =>
                {
                    b.Property<int>("LigaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivLige");

                    b.Property<int?>("UtakmiceRasporedRasporedUtakmiceId");

                    b.Property<string>("fourSqaureId");

                    b.Key("LigaId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.RasporedUtakmice", b =>
                {
                    b.Property<int>("RasporedUtakmiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("fourSqaureId");

                    b.Key("RasporedUtakmiceId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Tim", b =>
                {
                    b.Property<int>("TimId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bodovi");

                    b.Property<int>("CrveniKartoni");

                    b.Property<int>("GoloviTima");

                    b.Property<int?>("LigaLigaId");

                    b.Property<string>("NazivTima");

                    b.Property<int>("Nerjeseno");

                    b.Property<int>("Porazi");

                    b.Property<int>("PrimljeniGolovi");

                    b.Property<string>("TrenerTima");

                    b.Property<int>("ZutiKartoni");

                    b.Property<string>("fourSqaureId");

                    b.Key("TimId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Trener", b =>
                {
                    b.Property<int>("TrenerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Datum");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika")
                        .Annotation("Relational:ColumnType", "image");

                    b.Property<string>("fourSqaureId");

                    b.Key("TrenerId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Utakmica", b =>
                {
                    b.Property<int>("UtakmicaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojGolovaTim1");

                    b.Property<int>("BrojGolovaTim2");

                    b.Property<DateTime>("DatumiVrijeme");

                    b.Property<int?>("DelegatDelegatId");

                    b.Property<int?>("RasporedUtakmiceRasporedUtakmiceId");

                    b.Property<string>("Tim1");

                    b.Property<string>("Tim2");

                    b.Property<int>("Zuti");

                    b.Property<int>("crveni");

                    b.Property<string>("fourSqaureId");

                    b.Key("UtakmicaId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Delegat", b =>
                {
                    b.Reference("ProjekatNogometniSavez.Baza.Models.Liga")
                        .InverseCollection()
                        .ForeignKey("LigaLigaId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Igrac", b =>
                {
                    b.Reference("ProjekatNogometniSavez.Baza.Models.Tim")
                        .InverseCollection()
                        .ForeignKey("TimTimId");

                    b.Reference("ProjekatNogometniSavez.Baza.Models.Utakmica")
                        .InverseCollection()
                        .ForeignKey("UtakmicaUtakmicaId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Liga", b =>
                {
                    b.Reference("ProjekatNogometniSavez.Baza.Models.RasporedUtakmice")
                        .InverseCollection()
                        .ForeignKey("UtakmiceRasporedRasporedUtakmiceId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Tim", b =>
                {
                    b.Reference("ProjekatNogometniSavez.Baza.Models.Liga")
                        .InverseCollection()
                        .ForeignKey("LigaLigaId");
                });

            builder.Entity("ProjekatNogometniSavez.Baza.Models.Utakmica", b =>
                {
                    b.Reference("ProjekatNogometniSavez.Baza.Models.Delegat")
                        .InverseCollection()
                        .ForeignKey("DelegatDelegatId");

                    b.Reference("ProjekatNogometniSavez.Baza.Models.RasporedUtakmice")
                        .InverseCollection()
                        .ForeignKey("RasporedUtakmiceRasporedUtakmiceId");
                });
        }
    }
}
