using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Baza : DbContext
    {
        public Baza()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Baza;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Gatunek> Gatunki { get; set; }
        public DbSet<Widok> Widoki { get; set; }
        public DbSet<Tryb> TtrygGry { get; set; }
        public DbSet<NazwaGra> NazwaGry { get; set; } 
    }
}
