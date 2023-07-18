using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Requests.Receita;
using Application.Commands.Responses.Receita;
using Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitasController: ControllerBase
    {
        private readonly IMediator _mediator;

        public ReceitasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarReceita(
            decimal valor,
            string descricao,
            int categoria)
        {
            if(string.IsNullOrWhiteSpace(valor.ToString()))
            {
                return NotFound();
            }
            
            var request = new RegistrarReceitaRequest()
            {
                Valor = valor,
                Descricao = descricao,
                Categoria = (CategoriaReceita)categoria
            };
            
            var receitaCadastrada = await _mediator.Send(request, CancellationToken.None);
            
            if (receitaCadastrada.response == false)
            {
                return BadRequest("Receita não registrada com sucesso!");
            }
            return Ok("Receita registrada com sucesso!");
        }
    }
}