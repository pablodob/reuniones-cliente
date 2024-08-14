using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReunionUsuario
    {
        [Key]
        public int Id { get; set; }
        public Reunion? Reunion { get; set; }
        [ForeignKey("Reunion")]
        public int ReunionId { get; set; }
        public Usuario? Usuario { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public String Estado { get; set; }
    }
}
