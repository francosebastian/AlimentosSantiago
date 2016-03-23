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
    /// Clase cliente
    /// </summary>
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new List<Pedido>();
        }
        /// <summary>
        /// Asignamos el foreingKey
        /// </summary>
        [Key, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        /// <summary>
        /// Relacionamos el foreingKey
        /// </summary>
        public virtual Usuario Usuario { get; set; }
        /// <summary>
        /// Saldo del cliente en caso de que tenga convenio
        /// </summary>
        public int Saldo { get; set; }
        /// <summary>
        /// Campo referencial al id de la empresa si tiene convenio
        /// </summary>
        public int EmpresaId { get; set; }
        /// <summary>
        /// Indicamos la foreing key
        /// </summary>
        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }
        public String  Telefono { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
