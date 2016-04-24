using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProjekatNogometniSavez.TrenerBaza.Models;

namespace ProjekatNogometniSavezMigrations
{
    [ContextType(typeof(TrenerDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160424140552_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProjekatNogometniSavez.TrenerBaza.Models.Trener", b =>
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
        }
    }
}
