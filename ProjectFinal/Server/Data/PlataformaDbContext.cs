using Microsoft.EntityFrameworkCore;
using ProjectFinal.Shared.Models;

namespace ProjectFinal.Server.Data
{
    public class PlataformaDbContext : DbContext
    {
        public PlataformaDbContext(DbContextOptions<PlataformaDbContext> options) : base(options)
        {

        }
        public DbSet<Juego> Juegos { get; set; }
    }
}
