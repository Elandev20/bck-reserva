using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface IHotelRepository
    {
        Task SaveHotel(Hotel hotel);

        Task UpdateHotel(Hotel hotel);
    }
}
