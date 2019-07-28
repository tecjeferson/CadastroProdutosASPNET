using Microsoft.EntityFrameworkCore;
using CadastroProduto.Models;
namespace CadastroProduto.Database
{
    public class AppDBConection : DbContext
    {
        public DbSet<Produto> Produtos {get; set;}
        public AppDBConection(DbContextOptions<AppDBConection> options) : base(options)
        {

        }
    }
}