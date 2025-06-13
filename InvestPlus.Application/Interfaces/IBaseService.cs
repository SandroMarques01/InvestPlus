namespace InvestPlus.Application.Interfaces
{
    public interface IBaseService<T>
    {
        Task<T> CriarAsync(Guid usuarioId, T request);
        Task AtualizarAsync(Guid id, Guid usuarioId, T request);
        Task RemoverAsync(Guid id, Guid usuarioId);
        Task<T?> ListarPorIdAsync(Guid id, Guid usuarioId);
        Task<IEnumerable<T>> ListarPorUsuarioAsync(Guid usuarioId);
    }
}
