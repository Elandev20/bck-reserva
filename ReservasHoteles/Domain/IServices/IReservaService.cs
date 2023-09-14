using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IReservaService
    {
        Task SaveBooking(Reserva reserva);

        Task UpdateBooking(Reserva reserva);

        Task<Reserva> getReservaDetail(int idReserva);

        Task<List<Reserva>> getReserva();

        Task<Reserva> getReservaById(int id);
    }
}
