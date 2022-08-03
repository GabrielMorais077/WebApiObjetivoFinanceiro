using Microsoft.AspNetCore.Mvc;
using WebApiObjetivoFinanceiro.Data;
using WebApiObjetivoFinanceiro.Domain;
using WebApiObjetivoFinanceiro.Models;

namespace WebApiObjetivoFinanceiro.Controllers
{
    [ApiController]
    [Route("api/objetivos-finceiros")]
    public class ObjetivoFinanceiroController : ControllerBase

    {
        public readonly Context _context;
        public ObjetivoFinanceiroController(Context context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult listarTodos()
        {
            var objetivo = _context.Objetivos;
            return Ok(objetivo);
        }

        [HttpGet ("{Id}")]
        public IActionResult ListarporId (int Id)
        {
            var objetivos = _context.Objetivos.SingleOrDefault(o=>o.Id==Id); 
            return Ok(objetivos);
        }
        [HttpPost]
        public IActionResult PostarObjetivos (ObjetivoFinanceiroImputModel model)
        {
            var Objetivo = new ObjetivoFinanceiro(model.Titulo,model.ValorObjetivo,model.Descricao);
            _context.Objetivos.Add(Objetivo);
            var id = Objetivo.Id;
            return Ok(id);

            
                
            
        }
        [HttpPost("{id}/operacoes")]
        public IActionResult PostarOperacoes(int id, OperacoesImputModel model)
        {
            var operacoes = new Operacao(model.Tipo, model.Valor);
            var operacao= _context.Objetivos.SingleOrDefault(o=>o.Id==id);
            if (operacoes==null)
            {
                return NotFound();
            }
            operacao.realizarOperacao(operacoes);

            var retorno = "Operação feita com sucesso";
        
        }




    }
}
