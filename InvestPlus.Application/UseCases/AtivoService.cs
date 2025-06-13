using AutoMapper;
using InvestPlus.Application.Interfaces;
using InvestPlus.Domain.Interfaces;

namespace InvestPlus.Application.UseCases
{
    public class AtivoService : BaseService<Entities.Ativo>, IAtivoService
    {
        private readonly IMapper _mapper;
        private readonly IAtivoRepository _repo;

        public AtivoService(IAtivoRepository repo, IMapper mapper) : base(mapper)
        {
            _repo = repo;
        }

        public override async Task<Entities.Ativo> CriarAsync(Guid usuarioId, Entities.Ativo ativo)
        {
            await _repo.AdicionarAsync(ativo);
            return _mapper.Map<Entities.Ativo>(ativo);
        }

        public override async Task AtualizarAsync(Guid id, Guid usuarioId, Entities.Ativo ativo)
        {
            await _repo.AtualizarAsync(ativo);
        }

        public override async Task RemoverAsync(Guid id, Guid usuarioId)
        {
            var ativo = await _repo.ObterPorIdAsync(id, usuarioId)
                ?? throw new Exception("Ativo não encontrado");

            await _repo.RemoverAsync(ativo);
        }

        public override async Task<Entities.Ativo?> ListarPorIdAsync(Guid id, Guid usuarioId)
        {
            var ativo = await _repo.ObterPorIdAsync(id, usuarioId);
            return ativo == null ? null : _mapper.Map<Entities.Ativo>(ativo);
        }

        public override async Task<IEnumerable<Entities.Ativo>> ListarPorUsuarioAsync(Guid usuarioId)
        {
            var ativos = await _repo.ListarPorUsuarioAsync(usuarioId);
            return _mapper.Map<IEnumerable<Entities.Ativo>>(ativos);
        }
    }
}
