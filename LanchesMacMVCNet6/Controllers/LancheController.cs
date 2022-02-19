using LanchesMacMVCNet6.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMacMVCNet6.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;

            return View(lanches);
        }
    }
}
