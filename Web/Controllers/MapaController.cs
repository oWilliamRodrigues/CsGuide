using Application.Services;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class MapaController : Controller
    {
        private readonly MapaService _mapaService;
        public MapaController(MapaService mapaService)
        {
            _mapaService = mapaService;
        }
        public async Task<ActionResult> Index()
        {
            var mapas = await _mapaService.GetAllMapasAsync();
            return View(mapas);
        }
        public async Task<ActionResult> Detalhes(int id)
        {
            var mapa = await _mapaService.GetMapaByIdAsync(id);
            if (mapa == null)
            {
                return NotFound();
            }
            return View(mapa);
        }
    }
}