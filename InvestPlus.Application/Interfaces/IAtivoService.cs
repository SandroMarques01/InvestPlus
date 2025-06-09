using InvestPlus.Application.DTOs;

namespace InvestPlus.Application.Interfaces
{
    public interface IAtivoService : IBaseService<AtivoDto, CriarAtivoRequest, AtualizarAtivoRequest>
    {
        // Pode adicionar métodos específicos aqui
    }
}
