using Microsoft.EntityFrameworkCore;
using Taqueria.Modelos;


namespace Taqueria.Repositorio
{
    public class RepositorioPlatillo : IRepositorioPlatillo
    {
        private readonly TaqueriaDBContext _context;
        public RepositorioPlatillo(TaqueriaDBContext context)
        {
            _context = context;
        }

        public async Task<Platillo> Add(Platillo platillo)
        {
            await _context.Platillos.AddAsync(platillo);
            await _context.SaveChangesAsync();
            return platillo;
        }

        public async Task Delete(int id)
        {
            var platillo = await _context.Platillos.FindAsync(id);
            if (platillo != null)
            {
                _context.Platillos.Remove(platillo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Platillo?> Get(int id)
        {
            return await _context.Platillos.FindAsync(id);
        }

        public async Task<List<Platillo>> GetAll()
        {
            return await _context.Platillos.ToListAsync();
        }

        public async Task<List<Platillo>> GetPersonas()
        {
            return await _context.Platillos.ToListAsync();
        }

        public async Task Update(int id, Platillo platillo)
        {
            var platilloactual = await _context.Platillos.FindAsync(id);
            if (platilloactual != null)
            {
                platilloactual.Nombre = platillo.Nombre;
                platilloactual.Descripcion = platillo.Descripcion;
                platilloactual.Precio = platillo.Precio;
                await _context.SaveChangesAsync();
            }
        }
    }
}
