using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taak_12
{
    [Table("Artikels")]
    public abstract class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public virtual Artikelgroep Groep { get; set; }
        public int ArtikelGroepId { get; set; }
        public ICollection<Leverancier> Leveranciers { get; set; }
    }
}
