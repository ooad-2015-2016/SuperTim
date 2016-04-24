using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProjekatNogometniSavez.IgracBaza.Models;

namespace ProjekatNogometniSavezMigrations
{
    [ContextType(typeof(IgracDbContext))]
    partial class IgracDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProjekatNogometniSavez.IgracBaza.Models.Igrac", b =>
                {
                    b.Property<int>("IgracId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika")
                        .Annotation("Relational:ColumnType", "image");

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
        }
    }
}
