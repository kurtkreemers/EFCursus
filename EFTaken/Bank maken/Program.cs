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
    }
}
