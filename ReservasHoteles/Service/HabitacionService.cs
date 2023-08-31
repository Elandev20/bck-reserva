using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository _habitacionRepository;
        public HabitacionService(IHabitacionRepository habitacionRepository)
        {
            _habitacionRepository = habitacionRepository;
        }
        public async Task SaveRoom(Habitacion habitacion)
        {
            await _habitacionRepository.SaveRoom(habitacion);
        }
    }
}
