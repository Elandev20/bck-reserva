using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface IHabitacionRepository
    {
        Task SaveRoom(Habitacion hotel);
    }
}
