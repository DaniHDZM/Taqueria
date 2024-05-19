using Microsoft.EntityFrameworkCore;

namespace Taqueria.Modelos
{
    public class TaqueriaDBContext : DbContext
    {
        public TaqueriaDBContext(DbContextOptions<TaqueriaDBContext> options) : base(options) {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; } 
        public DbSet<Platillo> Platillos { get; set; }
    }
}
