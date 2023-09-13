using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Threading.Tasks;

namespace ReservasHoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller
    {
        public readonly IReservaService _reservaService;
        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [Route("SaveBooking")]
        [HttpPost]
        public async Task<IActionResult> SaveBooking(Reserva reserva)
        {
            try
            {
                await _reservaService.SaveBooking(reserva);
                return Ok(new { mesagge = "Reserva registrado" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [Route("UpdateBooking")]
        [HttpPut]
        public async Task<IActionResult> UpdateBooking(Reserva reserva)
        {
            try
            {
                await _reservaService.UpdateBooking(reserva);
                return Ok(new { mesagge = "Reserva actualizada" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("ListBooking")]
        public async Task<IActionResult> ListBooking()
        {
            try
            {
                return Ok(await _reservaService.getReserva());
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
