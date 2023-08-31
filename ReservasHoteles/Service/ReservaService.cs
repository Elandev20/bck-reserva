using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }
        public async Task SaveBooking(Reserva hotel)
        {
            await _reservaRepository.SaveBooking(hotel);
        }
    }
}
