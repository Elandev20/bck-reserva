﻿using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Repositories;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    public class HotelService : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task SaveHotel(Hotel hotel)
        {
            await _hotelRepository.SaveHotel(hotel);
        }
    }
}
