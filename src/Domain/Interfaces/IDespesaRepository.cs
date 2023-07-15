using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IDespesaRepository
    {
        Task AddDespesaAsync(Despesa despesa);
    }
}