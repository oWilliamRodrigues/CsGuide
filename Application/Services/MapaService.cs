using Application.DTOs;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class MapaService
    {
        private readonly IMapaRepository _mapaRepository;

        public MapaService(IMapaRepository mapaRepository)
        {
            _mapaRepository = mapaRepository;
        }

        public async Task<IEnumerable<MapaDTO>> GetAllMapasAsync()
        {
            var mapas = await _mapaRepository.GetAllAsync();
            return mapas.Select(m => new MapaDTO
            {
                Id = m.Id_mapa,
                Nome = m.Nome_mapa,
                Localizacao = m.Localizacao,
                Tamanho = m.Tamanho,
                Layout = m.Layout,
                LadoFavorito = m.Lado_favorito,
                Descricao = m.Descricao,
                ImagemUrl = m.Imagem_mapa
            });
        }

        public async Task<MapaDTO?> GetMapaByIdAsync(int id)
        {
            var mapa = await _mapaRepository.GetByIdAsync(id);
            if (mapa == null) return null;

            return new MapaDTO
            {
                Id = mapa.Id_mapa,
                Nome = mapa.Nome_mapa,
                Localizacao = mapa.Localizacao,
                Tamanho = mapa.Tamanho,
                Layout = mapa.Layout,
                LadoFavorito = mapa.Lado_favorito,
                Descricao = mapa.Descricao,
                ImagemUrl = mapa.Imagem_mapa
            };
        }
    }
}
