using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taak_12
{
    public class FoodArtikel : Artikel
    {
    
        public int Houdbaarheid { get; set; }
    }
}
