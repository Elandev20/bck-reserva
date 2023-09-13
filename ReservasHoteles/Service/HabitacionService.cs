using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository _habitacionRepository;
        public HabitacionService(IHabitacionRepository habitacionRepository)
        {
            _habitacionRepository = habitacionRepository;
        }

        public async Task<List<TipoHabitacion>> ListTypeRoom()
        {
            return await _habitacionRepository.ListTypeRoom();
        }

        public async Task SaveRoom(Habitacion habitacion)
        {
            await _habitacionRepository.SaveRoom(habitacion);
        }

        public async Task<List<Habitacion>> listRoomsByHotel(int id)
        {
            return await _habitacionRepository.listRoomsByHotel(id);
        }

        public async Task<Habitacion> listRoomsById(int id)
        {
            return await _habitacionRepository.listRoomsById(id);
        }

        public async Task UpdateRoom(Habitacion hotel)
        {
            await _habitacionRepository.UpdateRoom(hotel);
        }
    }
}
