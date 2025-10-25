using Domain.Models;

namespace Domain.Interfaces
{
    public interface IArmaRepository
    {
        Task<IEnumerable<Arma>> GetAllAsync();
        Task<Arma> GetByIdAsync(int id);
    }
}
