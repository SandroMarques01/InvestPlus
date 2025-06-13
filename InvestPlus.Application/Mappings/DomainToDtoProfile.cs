using AutoMapper;

namespace InvestPlus.Application.Mappings
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<Domain.Entities.Ativo, Entities.Ativo>();
            // Adicione os outros aqui
        }
    }
}
