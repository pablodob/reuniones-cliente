﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reunion //venia x default con internal, la puse public como la de usuario
    {
        public string? Titulo { get; set; } //Inventando hasta que este todo
        public string? Estado { get; set; }
        public string? Minuta { get; set; }
        public string? Temas { get; set; }
        public DateTime? FechaHora { get; set; }
        public Usuario? Coordinador { get; set; }
        [ForeignKey("Usuario")]
        public int? CoordinadorId { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
