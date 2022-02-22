using LanchesMacMVCNet6.Models;

namespace LanchesMacMVCNet6.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
