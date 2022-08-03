using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApiObjetivoFinanceiro.Exceptions
{ 

    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficente")
        {

        }
    }
}
