using GerenciadorOrdensServico.Context;
using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.Repositories
{
    public class OrdemServicoRepository : Repository<OrdemServico>, IOrdemServicoRepository
    {
        readonly AppDbContext _context;

        public OrdemServicoRepository(AppDbContext context) : base(context) { }
        public IEnumerable<OrdemServico> GetOrdemPorClientes(int id)
        {
            return GetAll().Where(p => p.Id == id);
        }
    }
}
