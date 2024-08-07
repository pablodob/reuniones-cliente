using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReunionUsuario
    {
        [Key]
        public int Id { get; set; }
        public Reunion ReunionId { get; set; }
        public Usuario UsuarioId { get; set; }
        public String Estado { get; set; }
    }
}
