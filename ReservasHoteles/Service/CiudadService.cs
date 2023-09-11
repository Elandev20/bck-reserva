using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    public class CiudadService : ICiudadService
    {
        private readonly ICiudadRepository _repository;
        public CiudadService(ICiudadRepository repository)
        {
            _repository = repository;
        }

        public Task<object> listCity()
        {
            return _repository.listCity();
        }
    }
}
