using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Taak_12
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Artikelgroep> ArtikelGroepen { get; set; }

        public DbSet<Leverancier> Leveranciers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodArtikel>().Map(m => m.Requires("Soort").HasValue("F"));
            modelBuilder.Entity<NonFoodArtikel>().Map(m => m.Requires("Soort").HasValue("N"));
        }
    }
}
