using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required]
        public string nombre { get; set; }
        [Required]
        public bool activo { get; set; }
        [Required]
        public int ciudadId { get; set; }
        [Required]
        public string imagen { get; set; }

        public string descripcion { get; set; }

        public Ciudad Ciudad { get; set; }

        public Habitacion Habitacion { get; set; }
    }
}
