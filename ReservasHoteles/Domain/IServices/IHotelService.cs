using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IHotelService
    {
        Task SaveHotel(Hotel hotel);

        Task UpdateHotel(Hotel hotel);
    }
}
