using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuario
    {

        public string? Nombre { get; set; }
        public string? NombreUsuario { get; set; }

        public string? Password { get; set; }

        [Key]
        public int Id { get; set; }

    }
}
