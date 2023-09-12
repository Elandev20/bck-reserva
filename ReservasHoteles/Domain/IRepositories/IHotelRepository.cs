using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface IHotelRepository
    {
        Task SaveHotel(Hotel hotel);

        Task UpdateHotel(Hotel hotel);

        Task<List<Hotel>> listHotels();

        Task<Hotel> listHotelsById(int id);

        Task disableHotel(int id);

        
    }
}
