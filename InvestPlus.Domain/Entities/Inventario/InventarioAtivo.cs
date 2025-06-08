using System;

namespace InvestPlus.Domain.Entities.Inventario
{
    public class InventarioAtivo
    {
        public Guid Id { get; set; }
        public Guid AtivoId { get; set; }
        public DateTime DataReferencia { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        // Navegação (opcional)
        public Ativo? Ativo { get; set; } = new Ativo();
    }
}
