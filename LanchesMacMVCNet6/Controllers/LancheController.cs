using LanchesMacMVCNet6.Models;
using LanchesMacMVCNet6.Repositories.Interfaces;
using LanchesMacMVCNet6.ViewModels;
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
        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(p => p.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                           .Where(p => p.Categoria.CategoriaNome.Equals(categoria))
                           .OrderBy(p => p.Nome);

                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheListViewModel);
        }

        public ViewResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(d => d.LancheId == lancheId);
            return View(lanche);
        }
    }
}
