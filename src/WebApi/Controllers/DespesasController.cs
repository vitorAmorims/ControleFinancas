using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Request.Despesa;
using Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DespesasController : ControllerBase
    {
        private readonly IMediator _mediator;
    
        public DespesasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarDespesa(
            string valor,
            string descricao,
            int categoria)
        {
            if(string.IsNullOrWhiteSpace(valor))
            {
                return NotFound();
            }
            
            var request = new RegistrarDespesaRequest()
            {
                Valor = Convert.ToDecimal(valor),
                Descricao = descricao,
                Categoria = (CategoriaDespesa)categoria
            };
            
            var despesaCadastrada = await _mediator.Send(request, CancellationToken.None);
            
            if (despesaCadastrada.response == false)
            {
                return BadRequest("Despesa não registrada com sucesso!");
            }
            return Ok("Despesa registrada com sucesso!");
        }
    }
}
