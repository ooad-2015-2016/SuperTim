using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProjekatNogometniSavezMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "RasporedUtakmice",
                columns: table => new
                {
                    RasporedUtakmiceId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedUtakmice", x => x.RasporedUtakmiceId);
                });
            migration.CreateTable(
                name: "Trener",
                columns: table => new
                {
                    TrenerId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column(type: "INTEGER", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "image", nullable: true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trener", x => x.TrenerId);
                });
            migration.CreateTable(
                name: "Liga",
                columns: table => new
                {
                    LigaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    NazivLige = table.Column(type: "TEXT", nullable: true),
                    UtakmiceRasporedRasporedUtakmiceId = table.Column(type: "INTEGER", nullable: true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liga", x => x.LigaId);
                    table.ForeignKey(
                        name: "FK_Liga_RasporedUtakmice_UtakmiceRasporedRasporedUtakmiceId",
                        columns: x => x.UtakmiceRasporedRasporedUtakmiceId,
                        referencedTable: "RasporedUtakmice",
                        referencedColumn: "RasporedUtakmiceId");
                });
            migration.CreateTable(
                name: "Delegat",
                columns: table => new
                {
                    DelegatId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column(type: "INTEGER", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    LigaLigaId = table.Column(type: "INTEGER", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delegat", x => x.DelegatId);
                    table.ForeignKey(
                        name: "FK_Delegat_Liga_LigaLigaId",
                        columns: x => x.LigaLigaId,
                        referencedTable: "Liga",
                        referencedColumn: "LigaId");
                });
            migration.CreateTable(
                name: "Tim",
                columns: table => new
                {
                    TimId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Bodovi = table.Column(type: "INTEGER", nullable: false),
                    CrveniKartoni = table.Column(type: "INTEGER", nullable: false),
                    DatumOsnivanja = table.Column(type: "INTEGER", nullable: false),
                    GoloviTima = table.Column(type: "INTEGER", nullable: false),
                    LigaLigaId = table.Column(type: "INTEGER", nullable: true),
                    NazivTima = table.Column(type: "TEXT", nullable: true),
                    Nerjeseno = table.Column(type: "INTEGER", nullable: false),
                    Porazi = table.Column(type: "INTEGER", nullable: false),
                    PrimljeniGolovi = table.Column(type: "INTEGER", nullable: false),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    TrenerTima = table.Column(type: "TEXT", nullable: true),
                    ZutiKartoni = table.Column(type: "INTEGER", nullable: false),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tim", x => x.TimId);
                    table.ForeignKey(
                        name: "FK_Tim_Liga_LigaLigaId",
                        columns: x => x.LigaLigaId,
                        referencedTable: "Liga",
                        referencedColumn: "LigaId");
                });
            migration.CreateTable(
                name: "Utakmica",
                columns: table => new
                {
                    UtakmicaId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    BrojGolovaTim1 = table.Column(type: "INTEGER", nullable: false),
                    BrojGolovaTim2 = table.Column(type: "INTEGER", nullable: false),
                    DatumiVrijeme = table.Column(type: "TEXT", nullable: false),
                    DelegatDelegatId = table.Column(type: "INTEGER", nullable: true),
                    RasporedUtakmiceRasporedUtakmiceId = table.Column(type: "INTEGER", nullable: true),
                    Tim1 = table.Column(type: "TEXT", nullable: true),
                    Tim2 = table.Column(type: "TEXT", nullable: true),
                    Zuti = table.Column(type: "INTEGER", nullable: false),
                    crveni = table.Column(type: "INTEGER", nullable: false),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utakmica", x => x.UtakmicaId);
                    table.ForeignKey(
                        name: "FK_Utakmica_Delegat_DelegatDelegatId",
                        columns: x => x.DelegatDelegatId,
                        referencedTable: "Delegat",
                        referencedColumn: "DelegatId");
                    table.ForeignKey(
                        name: "FK_Utakmica_RasporedUtakmice_RasporedUtakmiceRasporedUtakmiceId",
                        columns: x => x.RasporedUtakmiceRasporedUtakmiceId,
                        referencedTable: "RasporedUtakmice",
                        referencedColumn: "RasporedUtakmiceId");
                });
            migration.CreateTable(
                name: "Igrac",
                columns: table => new
                {
                    IgracId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    TimTimId = table.Column(type: "INTEGER", nullable: true),
                    UtakmicaUtakmicaId = table.Column(type: "INTEGER", nullable: true),
                    brojOdigranihUtakmica = table.Column(type: "INTEGER", nullable: false),
                    brojUtakmicaZaSuspenziju = table.Column(type: "INTEGER", nullable: false),
                    crveni = table.Column(type: "INTEGER", nullable: false),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true),
                    golovi = table.Column(type: "INTEGER", nullable: false),
                    podSuspenzijom = table.Column(type: "INTEGER", nullable: false),
                    zuti = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igrac", x => x.IgracId);
                    table.ForeignKey(
                        name: "FK_Igrac_Tim_TimTimId",
                        columns: x => x.TimTimId,
                        referencedTable: "Tim",
                        referencedColumn: "TimId");
                    table.ForeignKey(
                        name: "FK_Igrac_Utakmica_UtakmicaUtakmicaId",
                        columns: x => x.UtakmicaUtakmicaId,
                        referencedTable: "Utakmica",
                        referencedColumn: "UtakmicaId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Igrac");
            migration.DropTable("Trener");
            migration.DropTable("Tim");
            migration.DropTable("Utakmica");
            migration.DropTable("Delegat");
            migration.DropTable("Liga");
            migration.DropTable("RasporedUtakmice");
        }
    }
}
