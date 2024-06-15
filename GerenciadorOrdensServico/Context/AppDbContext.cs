using GerenciadorOrdensServico.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorOrdensServico.Context
{
    public class AppDbContext :DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
    }
}
