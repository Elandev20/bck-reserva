using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasHoteles.Domain.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        public string usuario { get; set; }
        
        public string contrasena { get; set; }

        public int perfil { get; set; }
    }
}
