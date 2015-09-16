using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_maken
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            List<Klant> klantenLijst = program.GetKlanten(); 
            foreach (var klant in klantenLijst)
            {
                Console.WriteLine(klant.KlantNr + ":"+ klant.Voornaam);
            }
            Console.WriteLine("Klantnr:");
            int result;
            while(!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Tik een getal:");
            }          
                Klant selectedklant = null;
                selectedklant = klantenLijst.Where(kl => kl.KlantNr == result).FirstOrDefault();
                if (selectedklant == null)
                    Console.WriteLine("Klant niet gevonden!!!");
                else
                {
                    Console.WriteLine("Geef het nieuw zichtrekeningnummer :");
                    var nieuweRekening = new Rekening { RekeningNr = Console.ReadLine(), KlantNr = selectedklant.KlantNr, Saldo = 0, Soort = "Z" };
                    using (var entities = new BankEntities())
                    {
                        entities.Rekeningen.Add(nieuweRekening);
                        entities.SaveChanges();
                    }
                }
                Console.WriteLine("");

            foreach (var kl in program.FindAllRekeningen() )
            {
                Console.WriteLine(kl.Voornaam);
                decimal totaal = 0;
                foreach (var rekening in kl.Rekeningen)
                {
                    
                    Console.WriteLine(rekening.RekeningNr + "=" + rekening.Saldo);
                    totaal += rekening.Saldo;
                }
                Console.WriteLine("Totaal : {0}",totaal);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        List<Klant> FindAllRekeningen()
        {
            using(var entities = new BankEntities())
            {
                return (from klant in entities.Klanten.Include("Rekeningen")
                        select klant).ToList();                      
            }
        }
        List<Klant> GetKlanten()
        {
            using(var entities = new BankEntities())
            {
                return (from klant in entities.Klanten
                        orderby klant.Voornaam
                        select klant).ToList();
            }
        }

    }
}
