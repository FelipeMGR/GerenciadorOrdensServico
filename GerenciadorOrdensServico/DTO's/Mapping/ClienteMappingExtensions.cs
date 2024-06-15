using AutoMapper;
using AutoMapper.Collection;
using GerenciadorOrdensServico.Models;

namespace GerenciadorOrdensServico.DTO_s.Mapping
{
    public class ClienteMappingExtensions : Profile
    {
        public ClienteMappingExtensions()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
