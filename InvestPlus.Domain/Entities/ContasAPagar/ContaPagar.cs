using System;
using System.Collections.Generic;

namespace InvestPlus.Domain.Entities
{
    public class ContaPagar
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Descricao { get; set; } = null!;
        public int DiaVencimento { get; set; }
        public decimal ValorEstimado { get; set; }
        public bool Status { get; set; }

        public Usuario? Usuario { get; set; }
        public ICollection<Pagamento> Parcelas { get; set; } = new List<Pagamento>();
    }
}
