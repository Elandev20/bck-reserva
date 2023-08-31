using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IHabitacionService
    {
        Task SaveRoom(Habitacion hotel);
    }
}
