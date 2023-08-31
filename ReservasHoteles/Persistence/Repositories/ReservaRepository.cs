using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AplicationDbContext _context;
        public ReservaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveBooking(Reserva reserva)
        {
            _context.Add(reserva);
            await _context.SaveChangesAsync();
        }
    }
}
