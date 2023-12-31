﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Service;
using System;
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
                Hotel newHotel = hotel;
                newHotel.imagen = newHotel.imagen.Replace("C:\\fakepath\\", "./assets/images/hotels/");
                await _hotelService.SaveHotel(newHotel);
                return Ok(new { mesagge = "Hotel registrado" });
            }
            catch (System.Exception)
            {
                return BadRequest(new { mesagge = "Error al momento de almacenar la información" });
                throw;
            }
        }

        [Route("UpdateHotel")]
        [HttpPut]
        public async Task<IActionResult> UpdateHotel(Hotel hotel)
        {
            try
            {
                Hotel newHotel = hotel;
                newHotel.imagen = newHotel.imagen.Replace("C:\\fakepath\\", "./assets/images/hotels/");
                await _hotelService.UpdateHotel(hotel);
                return Ok(new { mesagge = "Hotel actualizado" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [Route("disableHotel")]
        [HttpPut("{id}")]
        public async Task<IActionResult> disableHotel([FromQuery] int id)
        {
            try
            {
                await _hotelService.disableHotel(Convert.ToInt32(id));
                return Ok(new { mesagge = "Hotel modificado" });
            }
            catch (System.Exception)
            {
                return BadRequest(new { mesagge = "Error al momento de almacenar la información" });
                throw;
            }
        }


        [HttpGet("{idReserva}")]
        public async Task<IActionResult> ListBookingDetail(int idReserva)
        {
            try
            {
                return Ok(await _reservaService.getReservaDetail(idReserva));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("listHotels")]
        public async Task<IActionResult> ListHotels()
        {
            try
            {
                return Ok(await _hotelService.listHotels());
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("listHotelsById/{idHotel}")]
        public async Task<IActionResult> listHotelsById([FromRoute(Name = "idHotel")] int id)
        {
            try
            {
                return Ok(await _hotelService.listHotelsById(id));
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("listHotelsByCity/{idCity}")]
        public async Task<IActionResult> listHotelsByCity([FromRoute(Name = "idCity")] int id)
        {
            try
            {
                return Ok(await _hotelService.listHotelsByCity(id));
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }


}
