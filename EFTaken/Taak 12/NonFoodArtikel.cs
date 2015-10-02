using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taak_12
{
    public class NonFoodArtikel : Artikel
    {        
        public int Garantie { get; set; }
    }
}
