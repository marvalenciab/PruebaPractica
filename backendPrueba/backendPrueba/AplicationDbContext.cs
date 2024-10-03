using backendPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace backendPrueba
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        { 

        }
    }
}
