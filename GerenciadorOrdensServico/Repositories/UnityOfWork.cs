using GerenciadorOrdensServico.Context;

namespace GerenciadorOrdensServico.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private IClienteRepository? _cliente;
        private IOrdemServicoRepository? _ordem;
        public AppDbContext _context;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IOrdemServicoRepository _OrdemServicoRepository
        {
            get
            {
                return _ordem = _OrdemServicoRepository ?? new OrdemServicoRepository(_context);
            }
        }

        public IClienteRepository _ClienteRepository
        {
            get
            {
                return _cliente = _ClienteRepository ?? new ClienteRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
