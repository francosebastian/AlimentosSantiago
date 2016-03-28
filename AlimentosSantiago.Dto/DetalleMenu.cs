using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class DetalleMenu : LayerSuperType
    {
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }
        public int PlatoId { get; set; }
        [ForeignKey("PlatoId")]
        public virtual Plato Plato { get; set; }
    }
}
