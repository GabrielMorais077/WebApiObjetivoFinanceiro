using WebApiObjetivoFinanceiro.Enum;

using WebApiObjetivoFinanceiro.Exceptions;

namespace WebApiObjetivoFinanceiro.Domain
{   


    public class ObjetivoFinanceiro
    {
        public ObjetivoFinanceiro( string? titulo, decimal? valorObjetivo, string? descricao)
        {
            Id = new Random().Next(0,1000);
            Titulo = titulo;
            DataCriacao = DateTime.Now;
            ValorObjetivo = valorObjetivo;
            Descricao = descricao;
            Operacoes = new List<Operacao>();
        }

        public  int Id { get; private set; }
        public string? Titulo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public decimal? ValorObjetivo { get; private set; }
        public string? Descricao { get; private set; }
        public List<Operacao> Operacoes { get; private set; }
        public decimal Saldo => calculaSaldo();
        public decimal calculaSaldo ()
        {
        var calculaSaque = Operacoes.Where(o => o.Tipo == TipoOperacao.Saque).Sum(d => d.Valor);
        var calculaDeposito = Operacoes.Where(o => o.Tipo == TipoOperacao.Deposito).Sum(d => d.Valor);

        return calculaDeposito - calculaSaque;
        }
        public void realizarOperacao (Operacao operacao)
    {
        if (operacao.Tipo == TipoOperacao.Saque && operacao.Valor < Saldo)
        {
            throw new SaldoInsuficienteException();
        }
        Operacoes.Add(operacao);
    }

    }
}
