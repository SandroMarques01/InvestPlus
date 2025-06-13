using InvestPlus.Domain.Enums;

namespace InvestPlus.Domain.Entities
{
    public class Ativo : EntityBase
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Codigo { get; set; } 
        public string Nome { get; set; }
        public TipoAtivo Tipo { get; set; }
        public bool Status { get; set; }

        public Usuario? Usuario { get; set; }
        public ICollection<InventarioAtivo> Investarios { get; set; } = new List<InventarioAtivo>();
    }
}
