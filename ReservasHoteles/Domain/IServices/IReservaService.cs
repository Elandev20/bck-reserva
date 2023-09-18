using ReservasHoteles.Domain.Models;
using System;
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

        Task<object> filterHotels(Filter filter);

        Task<object> getRoomByHotel(Filter filter);
    }
}
