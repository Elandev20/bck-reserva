﻿using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly AplicationDbContext _context;

        public HabitacionRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoHabitacion>> ListTypeRoom()
        {
            return await _context.TipoHabitacion.ToListAsync();
        }

        public async Task SaveRoom(Habitacion habitacion)
        {
            _context.Add(habitacion);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Habitacion>> listRoomsByHotel(int id)
        {
            return await _context.Habitacion.Where(x => x.hotelId == id)
                .Include(x => x.TipoHabitacion)
                .ToListAsync();
        }

        public async Task<Habitacion> listRoomsById(int id)
        {
            return await _context.Habitacion.Where(x => x.habitacionId == id).Include(x => x.TipoHabitacion).FirstOrDefaultAsync();
        }

        public async Task UpdateRoom(Habitacion hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<object> getRoomsByHotel(int id)
        {
            return await _context.Habitacion.Join(_context.Reserva, hab => hab.hotelId, res => res.hotelId, (hab, res) => new {hab.habitacionId, hab.descripcion, })
                
                .ToListAsync();
        }
    }
}
