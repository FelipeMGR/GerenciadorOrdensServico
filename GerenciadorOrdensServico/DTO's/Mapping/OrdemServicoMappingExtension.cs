using AutoMapper;
using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.DTO_s.Mapping
{
    public class OrdemServicoMappingExtension : Profile
    {
        public OrdemServicoMappingExtension()
        {
            CreateMap<OrdemServico, OrdemServicoDTO>().ReverseMap();

        }
    }
}
