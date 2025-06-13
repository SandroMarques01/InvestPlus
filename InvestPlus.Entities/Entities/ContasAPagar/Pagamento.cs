namespace InvestPlus.Entities
{
    public class Pagamento : EntityBase
    {
        public Guid Id { get; set; }
        public Guid ContaPagarId { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public bool Paga { get; set; }

        // Navegação
        public ContaPagar? ContaPagar { get; set; }
    }
}
