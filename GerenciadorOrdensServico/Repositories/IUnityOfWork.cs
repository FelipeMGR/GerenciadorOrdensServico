namespace GerenciadorOrdensServico.Repositories
{
    public interface IUnityOfWork
    {
        IOrdemServicoRepository _OrdemServicoRepository { get; }
        IClienteRepository _ClienteRepository { get; }
        void Commit();

    }
}
