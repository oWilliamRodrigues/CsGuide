using Domain.Models;

namespace Domain.Interfaces
{
    public interface IMapaRepository
    {
        Task<IEnumerable<Mapa>> GetAllAsync();
        Task<Mapa> GetByIdAsync(int id);
    }
}
