using AutoMapper;
using InvestPlus.Application.Interfaces;

namespace InvestPlus.Application.UseCases
{
    public abstract class BaseService<TEntity>
        : IBaseService<TEntity>
    {
        protected readonly IMapper _mapper;

        protected BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public abstract Task<TEntity> CriarAsync(Guid usuarioId, TEntity request);
        public abstract Task AtualizarAsync(Guid id, Guid usuarioId, TEntity request);
        public abstract Task RemoverAsync(Guid id, Guid usuarioId);
        public abstract Task<TEntity?> ListarPorIdAsync(Guid id, Guid usuarioId);
        public abstract Task<IEnumerable<TEntity>> ListarPorUsuarioAsync(Guid usuarioId);
    }
}
