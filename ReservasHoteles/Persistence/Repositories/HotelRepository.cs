﻿using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.Models;
using ReservasHoteles.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservasHoteles.Persistence.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AplicationDbContext _context;

        public HotelRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task disableHotel(int id)
        {
            Hotel hotel = new Hotel();
            hotel = await _context.Hotel.Where(x => x.HotelId == id).FirstOrDefaultAsync();
            if (hotel.activo == true)
            {
                hotel.activo = false;
                _context.Update(hotel);
                await _context.SaveChangesAsync();
            }
            else
            {
                hotel.activo = true;
                _context.Update(hotel);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Hotel>> listHotels()
        {
            return await _context.Hotel.Include(x => x.Ciudad).ToListAsync();
                
        }

        public async Task<List<Hotel>> listHotelsByCity(int id)
        {
            return await _context.Hotel.Where(x => x.ciudadId == id && x.activo == true)
                .Include(x => x.Ciudad)
                .ToListAsync(); 
        }

        public async Task<Hotel> listHotelsById(int id)
        {
            return await _context.Hotel.Where(x => x.HotelId == id).Include(x => x.Ciudad).FirstOrDefaultAsync();
        }

        

        public async Task SaveHotel(Hotel hotel)
        {
             _context.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
