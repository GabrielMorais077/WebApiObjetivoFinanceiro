namespace WebApiObjetivoFinanceiro.Models
{
    public class ObjetivoFinanceiroImputModel
    {
        public ObjetivoFinanceiroImputModel(string titulo, decimal? valorObjetivo, string? descricao)
        {
            Titulo = titulo;
            ValorObjetivo = valorObjetivo;
            Descricao = descricao;
        }

        public String Titulo { get; set; }
        public Decimal? ValorObjetivo { get; set; }
        public String? Descricao { get; set; }
    }
}
