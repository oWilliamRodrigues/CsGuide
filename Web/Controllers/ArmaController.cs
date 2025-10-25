using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace Web.Controllers
{
    public class ArmaController : Controller
    {
        private readonly ArmaService _armaService;
        public ArmaController(ArmaService armaService)
        {
            _armaService = armaService;
        }
        public async Task<ActionResult> Index()
        {
            var armas = await _armaService.GetAllArmasAsync();
            return View(armas);
        }
        public async Task<ActionResult> Detalhes(int id)
        {
            var arma = await _armaService.GetArmaByIdAsync(id);
            if (arma == null)
            {
                return NotFound();
            }
            return View(arma);
        }
    }
}
