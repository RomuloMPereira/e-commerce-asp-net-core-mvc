using LanchesMacMVCNet6.Context;
using LanchesMacMVCNet6.Models;
using LanchesMacMVCNet6.Repositories.Interfaces;

namespace LanchesMacMVCNet6.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
