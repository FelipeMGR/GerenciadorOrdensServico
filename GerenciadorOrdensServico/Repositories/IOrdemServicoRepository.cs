using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.Repositories
{
    public interface IOrdemServicoRepository : IRepository<OrdemServico>
    {
        IEnumerable<OrdemServico> GetOrdemPorClientes(int id);
    }
}
