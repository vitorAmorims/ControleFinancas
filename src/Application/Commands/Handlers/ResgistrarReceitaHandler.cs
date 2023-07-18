using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Requests.Receita;
using Application.Commands.Responses.Receita;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using MediatR;

namespace Application.Commands.Handlers
{
  public class ResgistrarReceitaHandler : IRequestHandler<RegistrarReceitaRequest,
  RegistrarReceitaResponse>
  {
    private readonly IReceitaRepository _receitaRepository;
    private readonly IMapper _mapper;
    public ResgistrarReceitaHandler(IReceitaRepository receitaRepository, IMapper mapper)
    {
      _receitaRepository = receitaRepository;
      _mapper = mapper;
    }
    public async Task<RegistrarReceitaResponse> Handle(RegistrarReceitaRequest request, CancellationToken cancellationToken)
    {
      try
      {
        var receita = _mapper.Map<RegistrarReceitaRequest, Receita>(request);
        
        await _receitaRepository.AddReceitaAsync(receita);
        
        return await Task.FromResult(new RegistrarReceitaResponse(){response = true}) ;  
      }
      catch (Exception)
      {
        return new RegistrarReceitaResponse(){response = false};
      }
    }
  }
}