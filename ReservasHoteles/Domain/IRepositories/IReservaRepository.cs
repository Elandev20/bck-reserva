using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface IReservaRepository
    {
        Task SaveBooking(Reserva reserva);
    }
}
