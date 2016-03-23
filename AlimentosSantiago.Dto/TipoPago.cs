using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class TipoPago : LayerSuperType
    {
        [Required]
        public String Nombre { get; set; }
    }
}
