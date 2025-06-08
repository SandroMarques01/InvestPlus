using InvestPlus.Domain.Enums;
using System;
using System.Collections.Generic;

namespace InvestPlus.Domain.Entities.BolsaDeValores
{
    public class Papel
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
