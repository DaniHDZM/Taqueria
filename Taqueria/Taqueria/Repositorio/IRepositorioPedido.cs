using Taqueria.Modelos;

namespace Taqueria.Repositorio
{
    public interface IRepositorioPedido
    {
        Task<List<Pedido>> GetAll();
        Task<Pedido?> Get(int id);
        Task<List<Persona>> GetPersonas();
        Task<Pedido> Add(Pedido pedido);
        Task Update(int id, Pedido pedido);
        Task Delete(int id);
    }
}
