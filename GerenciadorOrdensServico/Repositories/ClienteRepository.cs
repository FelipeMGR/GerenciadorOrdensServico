using GerenciadorOrdensServico.Context;
using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context) : base(context) { }
    }
}
