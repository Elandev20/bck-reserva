using Microsoft.VisualBasic;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public Task<Reserva> getReservaDetail(int idReserva)
        {
            return _reservaRepository.getReservaDetail(idReserva);
        }

        public async Task SaveBooking(Reserva hotel)
        {
            await _reservaRepository.SaveBooking(hotel);
        }

        public async Task UpdateBooking(Reserva hotel)
        {
            await _reservaRepository.UpdateBooking(hotel);
        }

        public Task<List<Reserva>> getReserva()
        {
            return _reservaRepository.getReserva();
        }

        public async Task<Reserva> getReservaById(int id)
        {
            return await _reservaRepository.getReservaById(id);
        }

        public async Task<object> filterHotels(Filter filter)
        {
            return await _reservaRepository.filterHotels(filter); 
        }

        public async Task<object> getRoomByHotel(Filter filter)
        {
            return await _reservaRepository.getRoomByHotel(filter);
        }
    }
}
