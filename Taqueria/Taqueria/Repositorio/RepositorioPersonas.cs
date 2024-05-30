using Microsoft.EntityFrameworkCore;
using Taqueria.Modelos;

namespace Taqueria.Repositorios
{
    public class RepositorioPersonas : IRepositorioPersonas
    {

        private readonly TaqueriaDBContext _context;

        public RepositorioPersonas(TaqueriaDBContext context)
        {
            _context = context;
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Persona?> Get(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.Include(p=>p.Platillo).ToListAsync();
        }
        public async Task<List<Platillo>> GetPlatillo()
        {
            return await _context.Platillos.ToListAsync();
        }

        public async Task Update(int id, Persona persona)
        {
            var personaactual = await _context.Personas.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Nombre = persona.Nombre;
                personaactual.Telefono = persona.Telefono;
                personaactual.Dirección = persona.Dirección;
                await _context.SaveChangesAsync();
            }
        }
    }
}
