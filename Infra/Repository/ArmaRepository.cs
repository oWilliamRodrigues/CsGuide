using Domain.Interfaces;
using Domain.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repository
{
    public class ArmaRepository : IArmaRepository
    {
        private readonly CSGuideContext _context;

        public ArmaRepository(CSGuideContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Arma>> GetAllAsync()
        {
            return await _context.Armas.ToListAsync();
        }

        public async Task<Arma?> GetByIdAsync(int id)
        {
            return await _context.Armas.FirstOrDefaultAsync(a => a.Id_arma == id);
        }
    }
}
