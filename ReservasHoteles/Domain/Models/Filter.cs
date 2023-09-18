using System;

namespace ReservasHoteles.Domain.Models
{
    public class Filter
    {
        public int ciudadId { get; set; }

        public DateTime fInicio { get; set; }

        public DateTime fFin { get; set; }

        public int hotelId { get; set; }

        public int maxPersonas { get; set; }
    }
}
