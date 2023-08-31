using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Service;
using System.Threading.Tasks;

namespace ReservasHoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        public readonly IHotelService _hotelService;
        public readonly IHabitacionService _habitacionService;
        public readonly IReservaService _reservaService;
        public HotelController(IHotelService hotelService, IHabitacionService habitacionService, IReservaService reservaService) 
        {
            _hotelService = hotelService;
            _habitacionService = habitacionService;
            _reservaService = reservaService;
        }

        [Route("SaveHotel")]
        [HttpPost]
        public async Task<IActionResult> SaveHotel(Hotel hotel)
        {
            try
            {
                await _hotelService.SaveHotel(hotel);
                return Ok(new { mesagge = "Hotel registrado" });
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
    }


}
