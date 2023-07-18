using Application.Commands.Responses.Receita;
using Domain.Enum;
using MediatR;

namespace Application.Commands.Requests.Receita
{
    public class RegistrarReceitaRequest: IRequest<RegistrarReceitaResponse>
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public CategoriaReceita Categoria { get; set; }
    }
}