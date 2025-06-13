using InvestPlus.Domain.Entities;

namespace InvestPlus.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task AdicionarAsync(T ativo);
        Task AtualizarAsync(T ativo);
        Task RemoverAsync(T ativo);
        Task<T?> BuscarPorIdAsync(Guid id);
        Task<List<T>> BuscarTodosAsync(Guid id);
    }
}
