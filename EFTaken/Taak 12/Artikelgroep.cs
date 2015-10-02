using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taak_12
{
    [Table("ArtikelGroepen")]
    public class Artikelgroep
    {
  
        public int Id { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<Artikel> Artikels { get; set; }
    }
}
