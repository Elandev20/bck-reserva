﻿using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
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
                .Include(x => x.Hotel)
                .ToListAsync();
            return reser;
        }
    }
}
