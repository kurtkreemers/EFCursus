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

            Console.WriteLine("Geef het klantnummer :");
            int klantnr;
            if(int.TryParse(Console.ReadLine(),out klantnr))
            {
                using(var entities = new BankEntities())
                {
                    var klant = entities.Klanten.Find(klantnr);
                    if(klant != null)
                    {
                        if (klant.Rekeningen.Count() == 0)
                        {
                            entities.Klanten.Remove(klant);
                            entities.SaveChanges();
                        }
                        else
                            Console.WriteLine("Klant heeft nog rekeningen");
                    }
                    else
                    {
                        Console.WriteLine("Klant niet geveonden");
                    }
                }
            }
            else
                Console.WriteLine("Tik een getal");
            Console.ReadLine();
            //Console.WriteLine("Geeft het rekeningnummer : ");
            //using(var entities = new BankEntities())
            //{
            //    var selectedRekening = entities.Rekeningen.Find(Console.ReadLine());
            //    if(selectedRekening != null)
            //    {
            //        try
            //        {
            //            Console.WriteLine("Geef het te storten bedrag in :");
            //            decimal bedrag;
            //          while(decimal.TryParse(Console.ReadLine(), out bedrag) || bedrag <= 0m)
            //          {
            //              Console.WriteLine("Tik een positief bedag"); ;
            //          }
            //            //if (bedrag <= decimal.Zero)
            //            //{
            //            //    Console.WriteLine("Tik een positief getal ");
            //            //}
            //        }
            //        catch (FormatException)
            //        {

            //            Console.WriteLine("Tik een bedag"); ;
            //        }
                   
                
                   
            //    }
            //    else
            //        Console.WriteLine("Rekeningnummer niet gevonden");
            //}





            List<Klant> klantenLijst = program.GetKlanten(); 
            foreach (var klant in klantenLijst)
            {
                Console.WriteLine(klant.KlantNr + ":"+ klant.Voornaam);
            }
            Console.WriteLine("Klantnr:");
            int result;

            if(Int32.TryParse(Console.ReadLine(), out result))
            {
                Klant klant = null;
                klant = klantenLijst.Where(kl => kl.KlantNr == result).FirstOrDefault();
                if (klant == null)
                    Console.WriteLine("Klant niet gevonden!!!");
                else
                {
                    Console.WriteLine("Geef het nieuw zichtrekeningnummer :");
                    var nieuweRekening = new Rekening { RekeningNr = Console.ReadLine(), KlantNr = klant.KlantNr, Saldo = 0, Soort = "Z" };
                    using (var entities = new BankEntities())
                    {
                        entities.Rekeningen.Add(nieuweRekening);
                        entities.SaveChanges();
                    }
                }

            }
                else
                    Console.WriteLine("Tik een getal:");

            foreach (var klant in program.FindAllRekeningen() )
            {
                Console.WriteLine(klant.Voornaam);
                decimal totaal = 0;
                foreach (var rekening in klant.Rekeningen)
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
                        select klant).ToList();
            }
        }

    }
}
