using AutoMapper;
using Teste.Domain.Domain;
using Teste.Infra.Entity;

namespace Teste.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Logradouro, LogradouroModel>().ReverseMap();
            CreateMap<ClienteModel, Cliente>().ReverseMap();

        }
    }
}
