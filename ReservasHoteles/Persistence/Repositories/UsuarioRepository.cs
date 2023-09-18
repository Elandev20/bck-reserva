
using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AplicationDbContext _context;
        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Perfiles>> getPerfil()
        {
            return await _context.Perfil.ToListAsync();
        }

        public async Task<Usuario> Login(Usuario usuario)
        {
            try
            {
                return await _context.Usuario.Where(x => x.usuario == usuario.usuario && x.contrasena == usuario.contrasena).FirstOrDefaultAsync();
                
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }

        public async Task<List<Genero>> getGenero()
        {
            return await _context.Genero.ToListAsync();
        }

        public async Task<List<TipoDocumento>> getTipoDocumento()
        {
            return await _context.TipoDocumento.ToListAsync();
        }
    }
}
