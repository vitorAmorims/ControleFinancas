using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IReceitaRepository
    {
        Task AddReceitaAsync(Receita receita);
    }
}