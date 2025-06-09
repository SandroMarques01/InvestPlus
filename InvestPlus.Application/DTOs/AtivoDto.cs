namespace InvestPlus.Application.DTOs
{
    public class AtivoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = null!;
        public decimal ValorAtual { get; set; }
    }

    public class CriarAtivoRequest
    {
        public string Nome { get; set; } = null!;
        public decimal ValorInicial { get; set; }
    }

    public class AtualizarAtivoRequest
    {
        public string Nome { get; set; } = null!;
        public decimal ValorAtual { get; set; }
    }


}
