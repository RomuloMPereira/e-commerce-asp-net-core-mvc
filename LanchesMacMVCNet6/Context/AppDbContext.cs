using LanchesMacMVCNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMacMVCNet6.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
