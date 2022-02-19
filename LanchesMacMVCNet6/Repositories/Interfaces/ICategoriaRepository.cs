using LanchesMacMVCNet6.Models;

namespace LanchesMacMVCNet6.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
