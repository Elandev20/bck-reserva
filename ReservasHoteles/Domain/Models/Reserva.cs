using System;
using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Reserva
    {
        [Key]
        public int reservaId { get; set; }

        public int hotelId { get; set; }

        public int pasajeroId { get; set; }

        public DateTime fInicio { get; set; }

        public DateTime fFin { get; set; }

        public int ciudadDestino { get; set; }

        public Pasajero Pasajero { get; set; }

        public Hotel Hotel { get; set; }
    }
}
