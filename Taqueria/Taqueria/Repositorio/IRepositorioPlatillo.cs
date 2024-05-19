using Taqueria.Modelos;

namespace Taqueria.Repositorio
{
    public interface IRepositorioPlatillo
    {
        Task<List<Platillo>> GetAll();
        Task<Platillo?> Get(int id);
        Task<Platillo> Add(Platillo platillo);
        Task Update(int id, Platillo platillo);
        Task Delete(int id);
    }
}
