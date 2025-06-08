using InvestPlus.Domain.Enums;

namespace InvestPlus.Domain.Entities.Inventario
{
    public class Ativo
    {
        public Guid Id { get; set; }
        public Guid LoginId { get; set; }
        public string Codigo { get; set; } 
        public string Nome { get; set; }
        public TipoAtivo Tipo { get; set; }
        public bool Status { get; set; }

        public ICollection<InventarioAtivo> Investarios { get; set; } = new List<InventarioAtivo>();
    }
}
