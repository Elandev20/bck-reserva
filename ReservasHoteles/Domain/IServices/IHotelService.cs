using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IHotelService
    {
        Task SaveHotel(Hotel hotel);

        Task UpdateHotel(Hotel hotel);

        Task<List<Hotel>> listHotels();

        Task<Hotel> listHotelsById(int id);

        Task<List<Hotel>> listHotelsByCity(int id);

        Task disableHotel(int id);
    }
}
