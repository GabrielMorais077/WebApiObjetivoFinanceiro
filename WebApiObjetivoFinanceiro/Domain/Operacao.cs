using WebApiObjetivoFinanceiro.Enum;

namespace WebApiObjetivoFinanceiro.Domain
{
    public class Operacao
    {
        public Operacao(TipoOperacao tipo, decimal valor)
        {
            Id = new Random().Next(0, 1000);
            Tipo = tipo;
            Valor = valor;
            DataOperacao = DateTime.Now;
        }

        public int Id { get; private set; }
        public TipoOperacao Tipo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataOperacao { get; private set; }
    }
}


   
