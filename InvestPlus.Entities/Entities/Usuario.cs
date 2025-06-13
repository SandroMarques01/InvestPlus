namespace InvestPlus.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string SenhaHash { get; set; } = null!;

        // Relacionamentos (opcional, útil para filtros futuros)
        public ICollection<Ativo> Ativos { get; set; } = new List<Ativo>();
        public ICollection<Papel> Papeis { get; set; } = new List<Papel>();
        public ICollection<ContaPagar> ContasPagar { get; set; } = new List<ContaPagar>();
    }
}
