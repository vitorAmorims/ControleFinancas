using System;
using Application.Commands.Responses.Despesa;
using Domain.Enum;
using MediatR;

namespace Application.Commands.Request.Despesa
{
    public class RegistrarDespesaRequest: IRequest<RegistrarDespesaResponse>
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public CategoriaDespesa Categoria { get; set; }
    }
}