using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System;
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
                return BadRequest(new { mesagge = "Error al momento de almacenar la información" });
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


        [HttpGet]
        [Route("ListBookingById/{idBooking}")]
        public async Task<IActionResult> ListBooking([FromRoute(Name = "idBooking")] int id)
        {
            try
            {
                return Ok(await _reservaService.getReservaById(id));
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        [HttpPost]
        [Route("listFilter")]
        public async Task<IActionResult> listFilter(Filter filter)
        {
            try
            {
                return Ok(await _reservaService.filterHotels(filter));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("getRoomByHotel")]
        public async Task<IActionResult> getRoomByHotel(Filter filter)
        {
            try
            {
                return Ok(await _reservaService.getRoomByHotel(filter));
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
