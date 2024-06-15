using System.ComponentModel.DataAnnotations;

namespace GerenciadorOrdensServico.Models
{
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public Enums Status { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
