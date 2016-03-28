using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Menu : LayerSuperType
    {
        public Menu()
        {
            DetalleMenus = new List<DetalleMenu>();
        }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<DetalleMenu> DetalleMenus { get; set; }
     

    }
}
