using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Entity.Infrastructure;

namespace Bank_maken
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var entities = new BankEntities())
            {
                var zichtList = from rekening in entities.Rekeningen
                                where rekening is ZichtRekening
                                select rekening;
                foreach (var rek in zichtList)
                {
                    Console.WriteLine(rek.RekeningNr + " " + rek.Saldo);
                }
            }

            Console.ReadLine();
        ///   using (var entities = new BankEntities())
        ////    {
        ////        var hoogsteRang = (from perslid in entities.Personeel
        ////                           where perslid.ManagerNr == null
        ////                           select perslid).ToList();
        ////        new Program().visual(hoogsteRang, 0);
        ////        Console.ReadLine();
        ////    }

        //}
        //void visual(List<PersoneelsLid> personeelsleden, int rang)
        //{
        //    foreach (var perslid in personeelsleden)
        //    {
        //        Console.Write(new string('\t', rang));
        //        Console.WriteLine(perslid.Voornaam);
        //        if (perslid.Personeelsleden.Count != 0)
        //        {
        //            visual(perslid.Personeelsleden.ToList(), rang + 1);
        //        }
            
        //    }

           
        }


        //Program program = new Program();
        //try
        //{
        //    List<Klant> klantenLijst = program.GetKlanten();
        //    foreach (var klant in klantenLijst)
        //    {
        //        Console.WriteLine(klant.KlantNr + ":" + klant.Voornaam);
        //    }
        //    Console.WriteLine("Klantnr:");
        //    int result;

        //    if (Int32.TryParse(Console.ReadLine(), out result))
        //    {

        //            program.KlantVoornaamWijzigen(result);
        //    var nieuweRekening = new Rekening { RekeningNr = Console.ReadLine(), KlantNr = klant.KlantNr, Saldo = 0, Soort = "Z" };
        //    using (var entities = new BankEntities())
        //    {
        //        entities.Rekeningen.Add(nieuweRekening);
        //        entities.SaveChanges();
        //    }
        //}

        //Console.WriteLine("Geef het rekeningnummer voor de overschrijving :");
        //var vanRekening = Console.ReadLine();
        //Console.WriteLine("Geef het rekeningnummer naar welk het bedrag moet :");
        //var naarRekening = Console.ReadLine();
        //Console.WriteLine("Geef het bedrag in :");
        //var bedrag = int.Parse(Console.ReadLine());
        //program.Overschrijving(vanRekening, naarRekening, bedrag);
        //    }
        //    else
        //        Console.WriteLine("Tik een getal");
        //}
        //catch (FormatException ex)
        //{

        //    Console.WriteLine(ex.Message); 
        //}




        //void Overschrijving(string vanrekening, string naarrekening,int bedrag)
        //{
        //    var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead };
        //    using(var transactionScope = new TransactionScope(TransactionScopeOption.Required,transactionOptions))
        //    {
        //        using(var entities = new BankEntities())
        //        {
        //            var vanRek = entities.Rekeningen.Find(vanrekening);
        //            if(vanRek != null)
        //            {
        //                if(vanRek.Saldo >= bedrag)
        //                {
        //                    if (bedrag > 0)
        //                    {
        //                        var naarRek = entities.Rekeningen.Find(naarrekening);
        //                        if (naarRek != null)
        //                        {
        //                            vanRek.Saldo -= bedrag;
        //                            naarRek.Saldo += bedrag;
        //                            entities.SaveChanges();
        //                            transactionScope.Complete();
        //                        }
        //                        else
        //                            Console.WriteLine("Naar rekening niet gevonden");
        //                    }
        //                    else
        //                        Console.WriteLine("Tik een positief bedrag in");
        //                }
        //                else
        //                    Console.WriteLine("Saldo ontoereikend");
        //            }
        //            else
        //                Console.WriteLine("Van rekening niet gevonden");
        //        }
        //    }
        //}

        //Console.WriteLine("Geef het klantnummer :");
        //int klantnr;
        //if(int.TryParse(Console.ReadLine(),out klantnr))
        //{
        //    using(var entities = new BankEntities())
        //    {
        //        var klant = entities.Klanten.Find(klantnr);
        //        if(klant != null)
        //        {
        //            if (klant.Rekeningen.Count() == 0)
        //            {
        //                entities.Klanten.Remove(klant);
        //                entities.SaveChanges();
        //            }
        //            else
        //                Console.WriteLine("Klant heeft nog rekeningen");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Klant niet geveonden");
        //        }
        //    }
        //}
        //else
        //    Console.WriteLine("Tik een getal");
        //Console.ReadLine();
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


        //List<Klant> klantenLijst = program.GetKlanten(); 
        //foreach (var klant in klantenLijst)
        //{
        //    Console.WriteLine(klant.KlantNr + ":"+ klant.Voornaam);
        //}
        //Console.WriteLine("Klantnr:");
        //int result;

        //if(Int32.TryParse(Console.ReadLine(), out result))
        //{
        //    Klant klant = null;
        //    klant = klantenLijst.Where(kl => kl.KlantNr == result).FirstOrDefault();
        //    if (klant == null)
        //        Console.WriteLine("Klant niet gevonden!!!");
        //    else
        //    {
        //        Console.WriteLine("Geef het nieuw zichtrekeningnummer :");
        //        var nieuweRekening = new Rekening { RekeningNr = Console.ReadLine(), KlantNr = klant.KlantNr, Saldo = 0, Soort = "Z" };
        //        using (var entities = new BankEntities())
        //        {
        //            entities.Rekeningen.Add(nieuweRekening);
        //            entities.SaveChanges();
        //        }
        //    }

        //    }
        //        else
        //            Console.WriteLine("Tik een getal:");

        //    foreach (var klant in program.FindAllRekeningen() )
        //    {
        //        Console.WriteLine(klant.Voornaam);
        //        decimal totaal = 0;
        //        foreach (var rekening in klant.Rekeningen)
        //        {

        //            Console.WriteLine(rekening.RekeningNr + "=" + rekening.Saldo);
        //            totaal += rekening.Saldo;
        //        }
        //        Console.WriteLine("Totaal : {0}",totaal);
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}
        List<Klant> FindAllRekeningen()
        {
            using (var entities = new BankEntities())
            {
                return (from klant in entities.Klanten.Include("Rekeningen")
                        select klant).ToList();
            }
        }
        List<Klant> GetKlanten()
        {
            using (var entities = new BankEntities())
            {
                return (from klant in entities.Klanten
                        select klant).ToList();
            }
        }
        void KlantVoornaamWijzigen(int klantnr)
        {
            using (var entities = new BankEntities())
            {
                Klant klant = null;
                klant = entities.Klanten.Find(klantnr);
                if (klant == null)
                    Console.WriteLine("Klant niet gevonden!!!");
                else
                {
                    Console.WriteLine("Geef de gecorrigeerde voornaam : ");
                    klant.Voornaam = Console.ReadLine();

                    try
                    {
                        entities.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {

                        Console.WriteLine("Een andere gebruiker wijzigde deze klant");
                    }
                }
            }
        }

    }
}
