using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Service;
using System.Collections.Generic;
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

        
        [HttpGet("{idReserva}")]
        public async Task<IActionResult> ListBooking(int idReserva)
        {
            try
            {
                return Ok(await _reservaService.getReserva(idReserva));
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }


}
