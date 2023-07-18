using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories.Receita
{
    public class ReceitaRepository: IReceitaRepository
    {
        private List<Domain.Models.Receita> _receitas = new List<Domain.Models.Receita>();

        public Task AddReceitaAsync(Domain.Models.Receita receita)
        {
            System.Console.WriteLine("chegou aqui");
            _receitas.Add(receita);
        
            return Task.CompletedTask;
        }
  }
}