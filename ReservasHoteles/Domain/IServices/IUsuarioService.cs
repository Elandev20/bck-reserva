using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Domain.IServices
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);

        Task<List<Perfiles>> getPerfil();

        Task<Usuario> Login(Usuario usuario);
    }
}
