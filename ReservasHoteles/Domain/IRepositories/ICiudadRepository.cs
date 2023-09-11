using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface ICiudadRepository
    {
        Task<object> listCity();
    }
}
