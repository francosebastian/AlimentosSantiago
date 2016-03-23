using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    /// <summary>
    /// Clase que contiene las propiedades del usuario
    /// </summary>
    public class Usuario : LayerSuperType
    {
        /// <summary>
        ///  Email del usuario
        /// </summary>
        [Required]
        public String Email { get; set; }
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        [Required]
        public String Nombre { get; set; }
        /// <summary>
        /// Password del usuario
        /// </summary>
        [Required]
        public String Password { get; set; }
    }
}
