using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto
    {
        public string? Titulo { get; set; }
        public string? Link { get; set; }
        public bool? Obligatorio { get; set; }
        public int? ReunionId { get; set; }
        public Reunion? Reunion { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
