using InvestPlus.Domain.Enums;

namespace InvestPlus.Domain.Entities
{
    public class Provento : EntityBase
    {
        public Guid Id { get; set; }
        public Guid PapelId { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorPorCota { get; set; }
        public TipoProvento Tipo { get; set; }

        // Navegação
        public Papel? Papel { get; set; }
    }
}