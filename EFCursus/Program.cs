using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Entity.Infrastructure;

namespace EFCursus
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        entities.Docenten.Add(
        //        new Docent
        //        {
        //            Naam = new Naam { Voornaam = "Brigitta", Familienaam = "Roos" },
        //            Wedde = 2000,
        //            Geslacht = Geslacht.Vrouw,
        //            CampusNr = 1
        //        });
        //        entities.SaveChanges();
        //    }

            using (var entities = new OpleidingenEntities())
            {
                foreach (var docent in entities.Docenten)
                {
                    Console.WriteLine("{0}:{1}", docent.Naam, docent.Geslacht);
                }
            }
            //using (var entities = new OpleidingenEntities())
            //{
            //    foreach (var cursist in
            //    (from eenCursist in entities.Cursisten select eenCursist))
            //    {
            //        Console.WriteLine(cursist.Naam.FormeleBegroeting);
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Cursussen.Add(
            //    new ZelfstudieCursus { Naam = "Duitse correspondentie", Duurtijd = 6 });
            //    entities.SaveChanges();
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    entities.Cursussen.Add(
            //    new ZelfstudieCursus { Naam = "Italiaanse correspondentie", Duurtijd = 6 });
            //    entities.SaveChanges();
            //}
            
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen
            //                //where cursus is ZelfstudieCursus
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam + ' ' + cursus.GetType().Name);
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var cursist5 = entities.Cursisten.Find(5);
            //    if (cursist5 != null)
            //    {
            //        var cursist6 = entities.Cursisten.Find(6);
            //        if (cursist6 != null)
            //        {
            //            cursist5.Beschermelingen.Add(cursist6);
            //            entities.SaveChanges();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cursist 6 niet gevonden");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cursist 5 niet gevonden");
            //    }
            //}

            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from mentor in entities.Cursisten.Include("Beschermelingen")
            //                where mentor.Beschermelingen.Count != 0
            //                orderby mentor.Voornaam, mentor.Familienaam
            //                select mentor;
            //    foreach (var mentor in query)
            //    {
            //        Console.WriteLine("{0} {1}", mentor.Voornaam, mentor.Familienaam);
            //        foreach (var beschermeling in mentor.Beschermelingen)
            //        {
            //            Console.WriteLine("\t{0} {1}", beschermeling.Voornaam, beschermeling.Familienaam);
            //        }
            //    }
            //}
            //    var query = from cursist in entities.Cursisten.Include("Mentor")
            //                where cursist.Mentor != null
            //                orderby cursist.Voornaam, cursist.Familienaam
            //                select cursist;
            //    foreach (var cursist in query)
            //    {
            //        var mentor = cursist.Mentor;
            //        Console.WriteLine("{0} {1}: {2} {3}", cursist.Voornaam, cursist.Familienaam,
            //        mentor.Voornaam, mentor.Familienaam);
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursist in entities.Cursisten
            //                where cursist.Mentor == null
            //                orderby cursist.Voornaam, cursist.Familienaam
            //                select cursist;
            //    foreach (var cursist in query)
            //    {
            //        Console.WriteLine("{0} {1}", cursist.Voornaam, cursist.Familienaam);
            //    }
            //}
            //var nieuwBoek = new Boek() { ISBNNr = "0-201-70431-5", Titel = "Modern C++ Design" };
            //var transactionOptions = new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.Serializable };
            //using (var transactionScope = new System.Transactions.TransactionScope(
            //System.Transactions.TransactionScopeOption.Required, transactionOptions))
            //{
            //    using (var entities = new OpleidingenEntities())
            //    {
            //        // Cursus C++ ophalen
            //        // én het hoogste volgnr. van boek gebruikt in die cursus.
            //        // Met transactie met isolation level Serializable
            //        // kan daarna niemand anders een boek toevoegen aan C++ cursus
            //        // en is het nieuwe volgnr gelijk aan 1 + hoogst gelezen volgnr
            //        var query = from cursus in entities.Cursussen.Include("BoekenCursussen")
            //                    where cursus.Naam == "C++"
            //                    select new
            //                    {
            //                        Cursus = cursus,
            //                        HoogsteVolgnr = cursus.BoekenCursussen.Max(
            //                        boekCursus => boekCursus.VolgNr)
            //                    };
            //        var queryResult = query.FirstOrDefault();
            //        if (queryResult != null)
            //        {
            //            entities.BoekenCursussen.Add(new BoekCursus
            //            {
            //                Boek = nieuwBoek,
            //                Cursus = queryResult.Cursus,
            //                VolgNr = queryResult.HoogsteVolgnr + 1
            //            });
            //            entities.SaveChanges();
            //        }
            //        transactionScope.Complete();
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query =
            //    from cursus in entities.Cursussen.Include("BoekenCursussen.Boek")
            //    orderby cursus.Naam
            //    select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //        foreach (var boekCursus in cursus.BoekenCursussen)
            //        {
            //            Console.WriteLine("\t{0}:{1}", boekCursus.VolgNr, boekCursus.Boek.Titel);
            //        }
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var nieuwBoek = new Boek
            //    {
            //        ISBNNr = "0-0788210-6-1",
            //        Titel = "Oracle Backup & Recovery Handbook"
            //    };
            //    var oracleCursus = (from cursus in entities.Cursussen
            //                        where cursus.Naam == "Oracle"
            //                        select cursus).FirstOrDefault();
            //    if (oracleCursus != null)
            //    {
            //        oracleCursus.Boeken.Add(nieuwBoek);
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("cursus Oracle niet gevonden");
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from boek in entities.Boeken.Include("Cursussen")
            //                orderby boek.Titel
            //                select boek;
            //    foreach (var boek in query)
            //    {
            //        Console.WriteLine(boek.Titel);
            //        foreach (var cursus in boek.Cursussen)
            //        {
            //            Console.WriteLine("\t{0}", cursus.Naam);
            //        }
            //    }
            //}
            //using (var entities = new OpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen.Include("Boeken")
            //                orderby cursus.Naam
            //                select cursus;
            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //        foreach (var boek in cursus.Boeken)
            //        {
            //            Console.WriteLine("\t{0}", boek.Titel);
            //        }
            //    }
            //}
            Console.Read();
            //try
            //{
            //    Console.Write("Artikel nr.:");
            //    var artikelNr = int.Parse(Console.ReadLine());
            //    Console.Write("Magazijn nr.:");
            //    var magazijnNr = int.Parse(Console.ReadLine());
            //    Console.Write("Aantal stuks toevoegen:");
            //    var aantalStuks = int.Parse(Console.ReadLine());
            //    new Program().VoorraadBijvulling(artikelNr, magazijnNr, aantalStuks);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Tik een getal");
            //}
        }
        void VoorraadBijvulling(int artikelNr, int magazijnNr, int aantalStuks)
        {
            using (var entities = new OpleidingenEntities())
            {
                var voorraad = entities.Voorraden.Find(magazijnNr, artikelNr);
                if (voorraad != null)
                {
                    voorraad.AantalStuks += aantalStuks;
                    Console.WriteLine("Pas nu de voorraad aan met de Server Explorer," +
                    " druk daarna op Enter");
                    Console.ReadLine();
                    try
                    {
                        entities.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        
                        Console.WriteLine("Voorraad werd door andere applicatie aangepast.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Voorraad niet gevonden");
                }
            }
        //    try
        //    {
        //        Console.Write("Artikel nr.:");
        //        var artikelNr = int.Parse(Console.ReadLine());
        //        Console.Write("Van magazijn nr.:");
        //        var vanMagazijnNr = int.Parse(Console.ReadLine());
        //        Console.Write("Naar magazijn nr:");
        //        var naarMagazijnNr = int.Parse(Console.ReadLine());
        //        Console.Write("Aantal stuks:");
        //        var aantalStuks = int.Parse(Console.ReadLine());

        //        new Program().VoorraadTransfer(artikelNr, vanMagazijnNr, naarMagazijnNr,
        //        aantalStuks);
        //    }
        //    catch (FormatException)
        //    {

        //        Console.WriteLine("Tik een getal");
        //    }
        //}
        //void VoorraadTransfer(int artikelNr, int vanMagazijnNr, int naarMagazijnNr, int aantalStuks)
        //{
        //    var transactionOptions = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead };
        //    using(var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
        //    {
        //        using (var entities = new OpleidingenEntities())
        //        {
        //            var vanVoorraad = entities.Voorraden.Find(vanMagazijnNr, artikelNr);
        //            if (vanVoorraad != null)
        //            {
        //                if (vanVoorraad.AantalStuks >= aantalStuks)
        //                {
        //                    vanVoorraad.AantalStuks -= aantalStuks;
        //                    var naarVoorraad = entities.Voorraden.Find(naarMagazijnNr, artikelNr);
        //                    if (naarVoorraad != null)
        //                    {
        //                        naarVoorraad.AantalStuks += aantalStuks;
        //                    }
        //                    else
        //                    {
        //                        naarVoorraad = new Voorraad { ArtikelNr = artikelNr, MagazijnNr = naarMagazijnNr, AantalStuks = aantalStuks };
        //                        entities.Voorraden.Add(naarVoorraad);
        //                    }
        //                    entities.SaveChanges();
        //                    transactionScope.Complete();

        //                }
        //                else
        //                    Console.WriteLine("Te weinig voorraad voor transfer");
        //            }
        //            else
        //                Console.WriteLine("Artikel niet gevonden in magazijn {0}", vanMagazijnNr);
        //        }
        //    }
        }
        //Console.WriteLine("Minimum wedde");
        //decimal minWedde;
        //if (decimal.TryParse(Console.ReadLine(), out minWedde))
        //{
        //    Console.WriteLine("Sorteren: 1=op wedde; 2 =op familienaam, 3=op voornaam");
        //    var sorterenOp = Console.ReadLine();
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        IQueryable<Docent> query;
        //        switch (sorterenOp)
        //        {
        //            case "1":
        //                query = from docent in entities.Docenten
        //                        where docent.Wedde >= minWedde
        //                        orderby docent.Wedde
        //                        select docent;
        //                break;
        //            case "2":
        //                query = from docent in entities.Docenten
        //                        where docent.Wedde >= minWedde
        //                        orderby docent.Familienaam
        //                        select docent;
        //                break;
        //            case "3":
        //                query = from docent in entities.Docenten
        //                        where docent.Wedde >= minWedde
        //                        orderby docent.Voornaam
        //                        select docent;
        //                break;
        //            default:
        //                Console.WriteLine("Verkeerde keuze");
        //                query = null;
        //                break;

        //        }
        //        if (query != null)
        //        {

        //            foreach (var docent in query)
        //            {
        //                Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
        //            }
        //        }

        //    }
        //}
        //else
        //{
        //    Console.WriteLine("U tikte geen getal");
        //}

        //using (var entities = new OpleidingenEntities())
        //{
        //    Console.Write("DocentNr.:");
        //    int docentNr;
        //    if (int.TryParse(Console.ReadLine(), out docentNr))
        //    {
        //        var docent = entities.Docenten.Find(docentNr);
        //        Console.WriteLine(docent == null ? "Niet gevonden" : docent.Naam);
        //    }
        //    else
        //    {
        //        Console.WriteLine("U tikte geen getal");
        //    }
        //}

        //using (var entities = new OpleidingenEntities())
        //{
        //    var query = from campus in entities.Campussen
        //                orderby campus.Naam
        //                select new { campus.CampusNr, campus.Naam };
        //    foreach (var campusDeel in query)
        //    {
        //        Console.WriteLine("{0}: {1}", campusDeel.CampusNr, campusDeel.Naam);
        //    }
        //}
        ////using (var entities = new OpleidingenEntities())
        ////{
        ////    Console.Write("Voornaam:");
        ////    var voornaam = Console.ReadLine();
        ////    var query = from docent in entities.Docenten
        ////                where docent.Voornaam == voornaam
        ////                select docent;
        ////    foreach (var docent in query)
        ////    {
        ////        Console.WriteLine("{0} : {1}", docent.Naam, docent.Campus.Naam);
        ////    }
        ////}
        ////Console.ReadLine();
        //using (var entities = new OpleidingenEntities())
        //{
        //    Console.Write("Voornaam:");
        //    var voornaam = Console.ReadLine();
        //    var query = from docent in entities.Docenten.Include("Campus")
        //                where docent.Voornaam == voornaam
        //                select docent;
        //    foreach (var docent in query)
        //    {
        //        Console.WriteLine("{0}:{1}", docent.Naam, docent.Campus.Naam);
        //    }
        //}
        //using (var entities = new OpleidingenEntities())
        //{
        //    Console.Write("Deel naam campus:");
        //    var deelNaam = Console.ReadLine();
        //    var query = from campus in entities.Campussen.Include("Docenten")
        //                where campus.Naam.Contains(deelNaam)
        //                orderby campus.Naam
        //                select campus;
        //    foreach (var campus in query)
        //    {
        //        var campusNaam = campus.Naam;
        //        Console.WriteLine(campusNaam);
        //        Console.WriteLine(new string('-', campusNaam.Length));
        //        foreach (var docent in campus.Docenten)
        //        {
        //            Console.WriteLine(docent.Naam);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //var docent3 = new Docent
        //{
        //    Voornaam = "Voornaam3",
        //    Familienaam = "Familienaam3",
        //    Wedde = 3
        //};
        //using (var entities = new OpleidingenEntities())
        //{
        //    var campus1 = entities.Campussen.Find(1);
        //    if (campus1 != null)
        //    {
        //        entities.Docenten.Add(docent3);
        //        docent3.Campus = campus1;
        //        entities.SaveChanges();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Campus 1 niet gevonden");
        //    }
        //}
        //Console.Write("DocentNr.:");
        //int docentNr;
        //if (int.TryParse(Console.ReadLine(), out docentNr))
        //{
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        var docent = entities.Docenten.Find(docentNr);
        //        if (docent != null)
        //        {
        //            Console.WriteLine("Wedde:{0}", docent.Wedde);
        //            Console.Write("Bedrag:");
        //            decimal bedrag;
        //            if (decimal.TryParse(Console.ReadLine(), out bedrag))
        //            {
        //                docent.Opslag(bedrag);
        //                entities.SaveChanges();
        //            }
        //            else
        //            {
        //                Console.WriteLine("Tik een getal");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Docent niet gevonden");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Tik een getal");
        //}

        //using (var entities = new OpleidingenEntities())
        //{
        //    var campus1 = entities.Campussen.Find(1);
        //    if (campus1 != null)
        //    {
        //        foreach (var docent in campus1.Docenten)
        //        {
        //            docent.Opslag(10M);
        //        }
        //        entities.SaveChanges();
        //    }
        //}
        //using (var entities = new OpleidingenEntities())
        //{
        //    var docent1 = entities.Docenten.Find(1);
        //    if (docent1 != null)
        //    {
        //        docent1.CampusNr = 2;
        //        entities.SaveChanges();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Docent 1 niet gevonden");
        //    }
        //}
        //using (var entities = new OpleidingenEntities())
        //{
        //    var docent1 = entities.Docenten.Find(1);
        //    if (docent1 != null)
        //    {
        //        var campus3 = entities.Campussen.Find(3);
        //        if (campus3 != null)
        //        {
        //            campus3.Docenten.Add(docent1);
        //            entities.SaveChanges();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Campus 3 niet gevonden");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Docent 1 niet gevonden");
        //    }
        //}
        //Console.Write("Nummer docent:");
        //int docentNr;
        //if (int.TryParse(Console.ReadLine(), out docentNr))
        //{
        //    using (var entities = new OpleidingenEntities())
        //    {
        //        var docent = entities.Docenten.Find(docentNr);
        //        if (docent != null)
        //        {
        //            entities.Docenten.Remove(docent);
        //            entities.SaveChanges();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Docent niet gevonden");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Tik een getal");
        //}

        //Console.ReadLine();



    }
}
