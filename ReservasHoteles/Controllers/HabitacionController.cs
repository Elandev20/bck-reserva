using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Service;
using System.Threading.Tasks;

namespace ReservasHoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionController : Controller
    {
        public readonly IHabitacionService _habitacionService;
        public HabitacionController(IHabitacionService habitacionService)
        {
            _habitacionService = habitacionService;
        }

        [HttpGet("ListTypeRoom")]
        public async Task<IActionResult> ListTypeRoom(int idReserva)
        {
            try
            {
                return Ok(await _habitacionService.ListTypeRoom());
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [Route("SaveRoom")]
        [HttpPost]
        public async Task<IActionResult> SaveRoom(Habitacion habitacion)
        {
            try
            {
                await _habitacionService.SaveRoom(habitacion);
                return Ok(new { mesagge = "Habitacion registrado" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("listRoomsByHotel/{idHotel}")]
        public async Task<IActionResult> listRoomsByHotel([FromRoute(Name = "idHotel")] int id)
        {
            try
            {
                return Ok(await _habitacionService.listRoomsByHotel(id));
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
