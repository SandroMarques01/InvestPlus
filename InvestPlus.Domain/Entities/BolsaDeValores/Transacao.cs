using InvestPlus.Domain.Enums;

namespace InvestPlus.Domain.Entities
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public Guid PapelId { get; set; }
        public TipoTransacao Tipo { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal => Quantidade * ValorUnitario;

        // Navegação
        public Papel? Papel { get; set; }
    }
}
