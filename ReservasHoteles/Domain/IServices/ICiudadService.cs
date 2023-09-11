using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface ICiudadService
    {
        Task<object> listCity();
    }
}
