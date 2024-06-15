using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.DTO_s
{
    public class OrdemServicoDTO
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public int Preco { get; set; }
        public Enums Status { get; set; }
    }
}
