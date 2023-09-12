using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Repositories;
using System.Collections.Generic;
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

        public async Task UpdateHotel(Hotel hotel)
        {
            await _hotelRepository.UpdateHotel(hotel);
        }

        public async Task<List<Hotel>> listHotels()
        {
            return await _hotelRepository.listHotels();
        }

        public async Task<Hotel> listHotelsById(int id)
        {
            return await _hotelRepository.listHotelsById(id);
        }

        public async Task disableHotel(int id)
        {
            await _hotelRepository.disableHotel(id);
        }

        
    }
}
