using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Taak_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CodeFirstContext>());
            using (var context = new CodeFirstContext())
            {
                var ag = new Artikelgroep{ Naam = "Alcohol" };
                var fr = new Artikelgroep{Naam = "Fruit"};
                var leverancier1 = new Leverancier { Naam = "Inbev" };
                var leverancier2 = new Leverancier { Naam = "Vitamientje" };

                var artikel1 = new FoodArtikel { Naam = "Bier1", Groep = ag, Leveranciers = new List<Leverancier> {leverancier1} };
                var artikel2 = new FoodArtikel { Naam = "Bier2", Groep = ag, Leveranciers = new List<Leverancier> {leverancier1, leverancier2} };
                var artikel3 = new FoodArtikel { Naam = "Appel", Groep = fr };
                var artikel4 = new FoodArtikel { Naam = "Bier4",  Groep = ag };
                var artikel5 = new FoodArtikel { Naam = "Bier5", Groep = ag };
                var artikel6 = new FoodArtikel { Naam = "Appel6", Groep = fr };
                leverancier2.Artikels = new List<Artikel> {artikel4,artikel5};

                context.ArtikelGroepen.Add(ag);
                context.ArtikelGroepen.Add(fr);
                context.Artikels.Add(artikel1);
                context.Artikels.Add(artikel2);
                context.Artikels.Add(artikel3);
                context.Artikels.Add(artikel4);
                context.Artikels.Add(artikel5);
                context.Artikels.Add(artikel6);
                context.Leveranciers.Add(leverancier1);
                context.Leveranciers.Add(leverancier2);
                context.SaveChanges();
            }
        }
    }
}
