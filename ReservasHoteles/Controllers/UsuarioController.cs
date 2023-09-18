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

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            try
            {
                var login = await _usuarioService.Login(usuario);
                if (login == null)
                {
                    return BadRequest(new { mesagge = "Usuario o contraseña invalido" });
                }
                return Ok(login);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("getGender")]
        public async Task<List<Genero>> getGender()
        {
            try
            {
                return await _usuarioService.getGenero();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("getTypeDoc")]
        public async Task<List<TipoDocumento>> getTypeDoc()
        {
            try
            {
                return await _usuarioService.getTipoDocumento();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
