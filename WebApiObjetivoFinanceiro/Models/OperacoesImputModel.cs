using WebApiObjetivoFinanceiro.Enum;

namespace WebApiObjetivoFinanceiro.Models
{
    public class OperacoesImputModel
    {
        public OperacoesImputModel(TipoOperacao tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
        }

        public TipoOperacao Tipo { get; set; }
        public Decimal Valor { get; set; }
    }
}
