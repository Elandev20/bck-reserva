using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IReservaService
    {
        Task SaveBooking(Reserva reserva);
    }
}
