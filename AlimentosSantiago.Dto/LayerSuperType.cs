using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    /// <summary>
    /// Clase abstracta de LayerSuperType
    /// </summary>
    public abstract class LayerSuperType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Eliminado { get; set; }
        public bool Deshabilitado { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }


    }
}
