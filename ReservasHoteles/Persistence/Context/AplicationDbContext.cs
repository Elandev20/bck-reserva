using Microsoft.EntityFrameworkCore;
using ReservasHoteles.Domain.Models;

namespace ReservasHoteles.Persistence.Context
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Perfiles> Perfil { get; set; }

        public DbSet<Reserva> Reserva { get; set; }

        public DbSet<Hotel> Hotel { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }
    }
}
