using Domain.Interfaces;
using Domain.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class MapaRepository : IMapaRepository
    {
        private readonly CSGuideContext _context;

        public MapaRepository(CSGuideContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mapa>> GetAllAsync()
        {
            return await _context.Mapas.ToListAsync();
        }

        public async Task<Mapa?> GetByIdAsync(int id)
        {
            return await _context.Mapas.FirstOrDefaultAsync(m => m.Id_mapa == id);
        }
    }
}
