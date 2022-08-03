
using WebApiObjetivoFinanceiro.Domain;

namespace WebApiObjetivoFinanceiro.Data
{
    public class Context 
    {
        public List<ObjetivoFinanceiro> Objetivos { get; set; }
        public Context()
        {
            Objetivos = new List<ObjetivoFinanceiro>();
        }



    }
}
