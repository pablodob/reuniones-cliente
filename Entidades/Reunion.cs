using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reunion //venia x default con internal, la puse public como la de usuario
    {
        public string? Titulo { get; set; } //Inventando hasta que este todo
        public string? Estado { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
