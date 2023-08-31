using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IRepositories
{
    public interface IUsuarioRepository
    {
        Task SaveUser(Usuario usuario);

        Task<List<Perfiles>> getPerfil();

        Task<Usuario> Login(Usuario usuario);
    }
}
