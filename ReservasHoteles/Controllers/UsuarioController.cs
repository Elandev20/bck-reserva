using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            try
            {
               await  _usuarioService.SaveUser(usuario);
                return Ok(new { mesagge = "Usuario registrado" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet]

        public async Task<List<Perfiles>> Get()
        {
            try
            {
                return await _usuarioService.getPerfil();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
