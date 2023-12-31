﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ReservasHoteles.Domain.Models
{
    public class Reserva
    {
        [Key]
        public int reservaId { get; set; }

        public int hotelId { get; set; }

        public Int64 pasajeroId { get; set; }

        public DateTime fInicio { get; set; }

        public DateTime fFin { get; set; }

        public int habitacionId { get; set; }

        public string nombreEmergencia { get; set; }

        public Int64 telefonoEmergencia { get; set; }

        public Pasajero Pasajero { get; set; }

        public Hotel Hotel { get; set; }

        public Habitacion Habitacion { get; set; }


    }
}
