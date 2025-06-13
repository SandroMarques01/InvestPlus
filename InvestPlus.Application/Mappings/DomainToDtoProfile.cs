using AutoMapper;
using InvestPlus.Domain.Entities;
using InvestPlus.Application.DTOs;

namespace InvestPlus.Application.Mappings
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<Ativo, AtivoDto>();
            CreateMap<CriarAtivoRequest, Ativo>();
            CreateMap<AtualizarAtivoRequest, Ativo>();
            // Adicione os outros aqui
        }
    }
}
