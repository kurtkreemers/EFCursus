using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
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
            using (var entities = new OpleidingenEntities())
            {
                var docent1 = entities.Docenten.Find(1);
                if (docent1 != null)
                {
                    var campus3 = entities.Campussen.Find(3);
                    if (campus3 != null)
                    {
                        campus3.Docenten.Add(docent1);
                        entities.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Campus 3 niet gevonden");
                    }
                }
                else
                {
                    Console.WriteLine("Docent 1 niet gevonden");
                }
            }

            Console.ReadLine();


        }
    }
}
