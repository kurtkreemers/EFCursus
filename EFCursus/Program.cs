﻿using System;
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
            using (var entities = new OpleidingenEntities())
            {
                Console.Write("Deel naam campus:");
                var deelNaam = Console.ReadLine();
                var query = from campus in entities.Campussen.Include("Docenten")
                            where campus.Naam.Contains(deelNaam)
                            orderby campus.Naam
                            select campus;
                foreach (var campus in query)
                {
                    var campusNaam = campus.Naam;
                    Console.WriteLine(campusNaam);
                    Console.WriteLine(new string('-', campusNaam.Length));
                    foreach (var docent in campus.Docenten)
                    {
                        Console.WriteLine(docent.Naam);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

        }
    }
}
