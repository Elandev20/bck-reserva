using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly AplicationDbContext _context;

        public HabitacionRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task SaveRoom(Habitacion habitacion)
        {
            _context.Add(habitacion);
            await _context.SaveChangesAsync();
        }
    }
}
