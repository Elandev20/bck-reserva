using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AplicationDbContext _context;
        public ReservaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Reserva> getReservaDetail(int idReserva)
        {
            var reser = await _context.Reserva.Where(x => x.reservaId == idReserva)
                .Include(x => x.Pasajero)
                //.Include(x => x.Hotel)
                .FirstOrDefaultAsync();
            return reser;
        }

        public async Task SaveBooking(Reserva reserva)
        {
            _context.Add(reserva.Pasajero);
            await _context.SaveChangesAsync();

            _context.Add(reserva);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBooking(Reserva reserva)
        {
            _context.Update(reserva);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Reserva>> getReserva()
        {
            var reser = await _context.Reserva
                .Include(x => x.Pasajero)
                .ThenInclude(x => x.Genero)
                .Include(x => x.Pasajero)
                .ThenInclude(x => x.TipoDocumento)
                .Include(x => x.Hotel)
                .ThenInclude(x => x.Ciudad)
                .Include(x => x.Habitacion)
                .ThenInclude(x => x.TipoHabitacion)
                .ToListAsync();
            return reser;
        }

        public async Task<Reserva> getReservaById(int id)
        {
            var reser = await _context.Reserva
                .Include(x => x.Pasajero)
                .ThenInclude(x => x.Genero)
                .Include(x => x.Pasajero)
                .ThenInclude(x => x.TipoDocumento)
                .Include(x => x.Hotel)
                .ThenInclude(x => x.Ciudad)
                .Include(x => x.Habitacion)
                .ThenInclude(x => x.TipoHabitacion)
                .Where(x => x.reservaId == id).FirstOrDefaultAsync();
            return reser;
        }

        public async Task<object> filterHotels(Filter filter)
        {
            var reser = await _context.Reserva.Join(_context.Hotel, res => res.hotelId, hot => hot.HotelId, (res, hot) => new { hot.nombre, hot.imagen, res.fInicio, res.fFin, hot.ciudadId, res.hotelId, res.habitacionId }).Where(x => x.ciudadId == filter.ciudadId)
                //.Include(x => x.Pasajero)
                //.ThenInclude(x => x.Genero)
                //.Include(x => x.Pasajero)
                //.ThenInclude(x => x.TipoDocumento)
                //.Include(x => x.Hotel)
                //.ThenInclude(x => x.Ciudad)
                //.Include(x => x.Habitacion)
                //.ThenInclude(x => x.TipoHabitacion)
                .ToListAsync();
            return reser;
        }

        public async Task<object> getRoomByHotel(Filter filter)
        {

            try
            {
                List<Reserva> roomReserved = new List<Reserva>();
                roomReserved = await _context.Reserva
                    .Where(x => !(x.fInicio > filter.fFin || x.fFin < filter.fInicio) && x.hotelId == filter.hotelId).ToListAsync();

                List<Habitacion> listRoomFree = new List<Habitacion>();
                listRoomFree = await _context.Habitacion
                    .Include(x => x.TipoHabitacion)
                    .Where(x => x.hotelId == filter.hotelId && x.maxPersonas <= filter.maxPersonas).ToListAsync();
                foreach (var item in roomReserved)
                {
                    Habitacion deletelist = listRoomFree.Where(x => x.habitacionId == item.habitacionId).FirstOrDefault();
                    listRoomFree.Remove(deletelist);
                }

                return listRoomFree;
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
