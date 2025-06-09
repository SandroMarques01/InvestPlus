using AutoMapper;
using InvestPlus.Application.Interfaces;

namespace InvestPlus.Application.UseCases
{
    public abstract class BaseService<TEntity, TDto, TCreateRequest, TUpdateRequest>
        : IBaseService<TDto, TCreateRequest, TUpdateRequest>
    {
        protected readonly IMapper _mapper;

        protected BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public abstract Task<TDto> CriarAsync(Guid usuarioId, TCreateRequest request);
        public abstract Task AtualizarAsync(Guid id, Guid usuarioId, TUpdateRequest request);
        public abstract Task RemoverAsync(Guid id, Guid usuarioId);
        public abstract Task<TDto?> ListarPorIdAsync(Guid id, Guid usuarioId);
        public abstract Task<IEnumerable<TDto>> ListarPorUsuarioAsync(Guid usuarioId);
    }
}
