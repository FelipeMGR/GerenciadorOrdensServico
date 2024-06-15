using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.DTO_s
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int Telefone { get; set; }
        public ICollection<OrdemServico>? OrdemServico { get; set; }
    }
}
