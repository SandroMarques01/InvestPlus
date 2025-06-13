using InvestPlus.Enums;

namespace InvestPlus.Entities
{
    public class Papel : EntityBase
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Nome { get; set; }
        public TipoPapel TipoPapel { get; set; }
        public double? CotacaoAtual { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        // Navegação
        public Usuario? Usuario { get; set; }
        public ICollection<Provento> Proventos { get; set; } = new List<Provento>();
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
