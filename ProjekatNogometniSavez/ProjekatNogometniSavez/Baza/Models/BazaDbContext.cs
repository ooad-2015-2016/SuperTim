using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProjekatNogometniSavez.Baza.Models
{
    class BazaDbContext:DbContext
    {
        
        public DbSet<Trener> Treneri { get; set; }
        public DbSet<Delegat> Delegati { get; set; }
        public DbSet<Igrac> Igraci { get; set; }
        public DbSet<Utakmica> Utakmice { get; set; }
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<Liga> Liga { get; set; }
        public DbSet<RasporedUtakmice> RasporedUtakmica { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "NogometniSavezBaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Trener>().Property(p => p.Slika).HasColumnType("image");
        }
    }
}

