using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IHabitacionService
    {
        Task SaveRoom(Habitacion hotel);

        Task<List<TipoHabitacion>> ListTypeRoom();

        Task<List<Habitacion>> listRoomsByHotel(int id);

        Task<Habitacion> listRoomsById(int id);

        Task UpdateRoom(Habitacion hotel);
    }
}
