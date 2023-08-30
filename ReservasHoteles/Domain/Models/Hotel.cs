using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Hotel
    {
        [Key]
        public int idHotel { get; set; }

        public string nombre { get; set; }

        public bool activo { get; set; }
    }
}
