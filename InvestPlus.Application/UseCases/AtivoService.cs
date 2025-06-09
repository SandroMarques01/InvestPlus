using AutoMapper;
using InvestPlus.Domain.Entities;
using InvestPlus.Application.DTOs;
using InvestPlus.Application.Interfaces;

namespace InvestPlus.Application.UseCases
{
    public class AtivoService : BaseService<Ativo, AtivoDto, CriarAtivoRequest, AtualizarAtivoRequest>, IAtivoService
    {
        private readonly IAtivoRepository _repo;

        public AtivoService(IAtivoRepository repo, IMapper mapper) : base(mapper)
        {
            _repo = repo;
        }

        public override async Task<AtivoDto> CriarAsync(Guid usuarioId, CriarAtivoRequest request)
        {
            var ativo = new Ativo
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                ValorAtual = request.ValorInicial,
                UsuarioId = usuarioId
            };

            await _repo.AdicionarAsync(ativo);
            return _mapper.Map<AtivoDto>(ativo);
        }

        public override async Task AtualizarAsync(Guid id, Guid usuarioId, AtualizarAtivoRequest request)
        {
            var ativo = await _repo.ObterPorIdAsync(id, usuarioId)
                ?? throw new Exception("Ativo não encontrado");

            ativo.Nome = request.Nome;
            ativo.ValorAtual = request.ValorAtual;

            await _repo.AtualizarAsync(ativo);
        }

        public override async Task RemoverAsync(Guid id, Guid usuarioId)
        {
            var ativo = await _repo.ObterPorIdAsync(id, usuarioId)
                ?? throw new Exception("Ativo não encontrado");

            await _repo.RemoverAsync(ativo);
        }

        public override async Task<AtivoDto?> ListarPorIdAsync(Guid id, Guid usuarioId)
        {
            var ativo = await _repo.ObterPorIdAsync(id, usuarioId);
            return ativo == null ? null : _mapper.Map<AtivoDto>(ativo);
        }

        public override async Task<IEnumerable<AtivoDto>> ListarPorUsuarioAsync(Guid usuarioId)
        {
            var ativos = await _repo.ListarPorUsuarioAsync(usuarioId);
            return _mapper.Map<IEnumerable<AtivoDto>>(ativos);
        }
    }
}
