using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class CiudadRepository : ICiudadRepository
    {
        private readonly AplicationDbContext _context;
        public CiudadRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<object> listCity()
        {
            return await _context.Ciudad.Select(x => new  { Id = x.CiudadId, Descripcion = x.CiudadNombre.Trim(), Pais = x.PaisCodigo}).Where(x => x.Pais == "COL").ToListAsync();
        }
    }


}
