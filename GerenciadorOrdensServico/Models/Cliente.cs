using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using GerenciadorOrdensServico.Validations;

namespace GerenciadorOrdensServico.Models
{
    public class Cliente
    {
        public Cliente()
        {
            OrdemServico = new Collection<OrdemServico>();
        }
       [Key]
        [IdValidation]
       public int Id { get; set; }
        [NameValidation]
       public string? Nome { get; set; }
       public string? Email { get; set; }
       public int Telefone { get; set; }
        [CollectionVallidation]
       public ICollection<OrdemServico>? OrdemServico { get; set; }
    }
}
