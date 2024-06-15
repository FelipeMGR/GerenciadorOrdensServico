using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace GerenciadorOrdensServico.Validations
{
    public class CollectionVallidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Nenhuma ordem de serviço foi encontrada.");
            }

            //obtem o tipo de value e armazena variavel type.
            var type = value.GetType();
            //verifica se value implementa a interface ICollection, e se ela é generica.
            if (type.IsGenericType && typeof(ICollection<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
            {

                //obtem o tipo de coleção.
                var args = type.GetGenericArguments();
                //armazena o tipo de coleção obtida em args. Isso faz a coleção deixar de ser genérica, temporariamente, e passa a ser tipo Cliente ou Ordem de Serviço.
                var collectionType = typeof(ICollection<>).MakeGenericType(args);

                //Obtém a proprieda count
                var countProperty =collectionType.GetProperty("Count");
                //atribui a quantidade de itens contidos na coleção.
                var count = (int)countProperty.GetValue(value);

                if (count > 0)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Ao menos uma ordem de serviço precisa ser registrada.");
                }

            }
            else
            {
                return new ValidationResult("Atributo só pode ser atribuído à coleções.");
            }
        }
    }
}
