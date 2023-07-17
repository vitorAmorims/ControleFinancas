using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Request.Despesa;
using Application.Commands.Responses.Despesa;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using MediatR;

namespace Application.Commands.Handlers
{
  public class ResgistrarDespesaHandler : IRequestHandler<RegistrarDespesaRequest,
    RegistrarDespesaResponse>
  {
    private readonly IDespesaRepository _despesaRepository;
    private readonly IMapper _mapper;

    public ResgistrarDespesaHandler(IDespesaRepository despesaRepository, IMapper mapper)
    {
      _despesaRepository = despesaRepository;
      _mapper = mapper;
    } 
    public async Task<RegistrarDespesaResponse> Handle(RegistrarDespesaRequest request, CancellationToken cancellationToken)
    {
      try
      {
        var despesa = _mapper.Map<RegistrarDespesaRequest, Despesa>(request);
        
        await _despesaRepository.AddDespesaAsync(despesa);
        
        return await Task.FromResult(new RegistrarDespesaResponse(){response = true}) ;  
      }
      catch (Exception)
      {
        return new RegistrarDespesaResponse(){response = false};
      }
      
    }
  }
}