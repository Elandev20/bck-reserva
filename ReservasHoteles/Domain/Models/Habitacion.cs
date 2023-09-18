using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasHoteles.Domain.Models
{
    public class Habitacion
    {
        [Key]
        public int habitacionId { get; set; }

        public string descripcion { get; set; }

        public int tipoHabitacionId { get; set; }

        public int impuesto { get; set; }

        public int precioHabitacion { get; set; }

        public bool activo { get; set; }

        public int numeroHabitacion { get; set; }

        public int hotelId { get; set; }

        public int maxPersonas { get; set; }

        public TipoHabitacion TipoHabitacion { get; set; }

    }
}
