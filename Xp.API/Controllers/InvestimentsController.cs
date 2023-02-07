using Microsoft.AspNetCore.Mvc;
using Xp.Domain.Entities;
using Xp.Services.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Xp.API.Controllers
{
    [Route("investimentos")]
    [ApiController]
    public class InvestimentsController : ControllerBase
    {
       CorretoraService _corretoraService;

        public InvestimentsController(CorretoraService corretoraService)
        {
            _corretoraService = corretoraService;
        }

        // GET: api/<InvestimentsController>
        [HttpGet("{codCliente}")]
        public string Comprar(int codCliente, int codAtivo, int qtdeAtivo)
        {
            Corretora corretora = _corretoraService.SearchById(1);

            if (qtdeAtivo > corretora.QtAtivo)
                return "A quantidade de ativo solicitada é maior do que o possuído pela corretora";

            corretora.QtAtivo -= qtdeAtivo;
            _corretoraService.Update(corretora);

            return $"Foi realizado a compra de {qtdeAtivo} para o cliente com código {codCliente} e código de ativo {codAtivo}";
        }

        // GET api/<InvestimentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InvestimentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InvestimentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvestimentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
