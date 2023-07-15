using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories
{
  public class DespesaRepository : IDespesaRepository
  {
    private List<Despesa> _despesas = new List<Despesa>();
    public Task AddDespesaAsync(Despesa despesa)
    {
        _despesas.Add(despesa);
        
        return Task.CompletedTask;
    }
  }
}