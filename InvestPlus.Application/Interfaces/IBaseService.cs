namespace InvestPlus.Application.Interfaces
{
    public interface IBaseService<TDto, in TCreateRequest, in TUpdateRequest>
    {
        Task<TDto> CriarAsync(Guid usuarioId, TCreateRequest request);
        Task AtualizarAsync(Guid id, Guid usuarioId, TUpdateRequest request);
        Task RemoverAsync(Guid id, Guid usuarioId);
        Task<TDto?> ListarPorIdAsync(Guid id, Guid usuarioId);
        Task<IEnumerable<TDto>> ListarPorUsuarioAsync(Guid usuarioId);
    }
}
