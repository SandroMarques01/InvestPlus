using InvestPlus.Domain.Enums;

namespace InvestPlus.Domain.Entities
{
    public class Ativo
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; } 
        public string Nome { get; set; }
        public TipoAtivo Tipo { get; set; }


    }
}
