using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasHoteles.Domain.Models
{
    public class Usuario
    {
        [Key]
        public int cedula { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string apellido { get; set; }

        public string email { get; set; }

        public int celular { get; set; }

        public string contrasena { get; set; }

        public int perfil { get; set; }
    }
}
