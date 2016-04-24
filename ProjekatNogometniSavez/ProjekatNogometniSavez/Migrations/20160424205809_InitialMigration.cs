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
                name: "Igrac",
                columns: table => new
                {
                    IgracId = table.Column(type: "INTEGER", nullable: false)
                        //.Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "image", nullable: true),
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
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Igrac");
        }
    }
}
