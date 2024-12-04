using AsAPi.Models;
using Microsoft.EntityFrameworkCore;


namespace AsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<pedido> Pedidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
