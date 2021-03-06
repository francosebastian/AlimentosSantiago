﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class CategoriaPlato : LayerSuperType
    {
        public CategoriaPlato(){ Platos = new List<Plato>(); }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public virtual ICollection<Plato> Platos { get; set;}
    }
}

