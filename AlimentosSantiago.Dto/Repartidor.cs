using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Repartidor
    {
        /// <summary>
        /// Asignamos el foreingKey
        /// </summary>
        [Key, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        /// <summary>
        /// Relacionamos el foreingKey
        /// </summary>
        public virtual Usuario Usuario { get; set; }
    }
}
