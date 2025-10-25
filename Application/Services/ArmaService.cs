using Application.DTOs;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class ArmaService
    {
        private readonly IArmaRepository _armaRepository;

        public ArmaService(IArmaRepository armaRepository)
        {
            _armaRepository = armaRepository;
        }

        public async Task<IEnumerable<ArmaDTO>> GetAllArmasAsync()
        {
            var armas = await _armaRepository.GetAllAsync();
            return armas.Select(a => new ArmaDTO
            {
                Id = a.Id_arma,
                Nome = a.Nome_arma,
                Tipo = a.Tipo,
                Dano = a.Dano,
                Precisao = a.Precisao,
                Cadencia = a.Cadencia,
                Preco = a.Preco,
                Descricao = a.Descricao,
                ImagemUrl = a.Imagem_arma
            });
        }

        public async Task<ArmaDTO?> GetArmaByIdAsync(int id)
        {
            var arma = await _armaRepository.GetByIdAsync(id);
            if (arma == null) return null;

            return new ArmaDTO
            {
                Id = arma.Id_arma,
                Nome = arma.Nome_arma,
                Tipo = arma.Tipo,
                Dano = arma.Dano,
                Precisao = arma.Precisao,
                Cadencia = arma.Cadencia,
                Preco = arma.Preco,
                Descricao = arma.Descricao,
                ImagemUrl = arma.Imagem_arma
            };
        }
    }
}
