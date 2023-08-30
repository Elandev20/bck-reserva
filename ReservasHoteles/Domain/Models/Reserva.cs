using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Reserva
    {
        [Key]
        public int reservaId { get; set; }

        public int hotelId { get; set; }

        public int usuarioId { get; set; }

        public DateTime fInicio { get; set; }

        public DateTime fFin { get; set; }
    }
}
