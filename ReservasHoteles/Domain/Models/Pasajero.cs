using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Pasajero
    {
        [Key]
        public int cedula { get; set; }

        public string nombre { get; set; }

        public int genero { get; set; }

        public int tipoDocumento { get; set; }

        public string email { get; set; }

        public int telefono { get; set; }
    }
}
