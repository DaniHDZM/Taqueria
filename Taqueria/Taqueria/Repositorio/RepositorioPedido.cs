using Microsoft.EntityFrameworkCore;
using Taqueria.Modelos;


namespace Taqueria.Repositorio
{
    public class RepositorioPedido : IRepositorioPedido
    {


        private readonly TaqueriaDBContext _context;

        public RepositorioPedido(TaqueriaDBContext context)
        {
            _context = context;
        }

        public async Task<Pedido> Add(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task Delete(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Pedido?> Get(int id)
        {
            return await _context.Pedidos.FindAsync(id); 
        }

        public async Task<List<Pedido>> GetAll()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task<List<Persona>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task Update(int id, Pedido pedido)
        {
            var pedidoactual = await _context.Pedidos.FindAsync(id);
            if (pedidoactual != null)
            {
                pedidoactual.Fecha = pedido.Fecha;
                pedidoactual.HoraPedido = pedido.HoraPedido;
                pedidoactual.EstadoPedido = pedido.EstadoPedido;
                await _context.SaveChangesAsync();
            }
        }
    }
}
