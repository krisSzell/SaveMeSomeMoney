using SaveMeSomeMoney.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Services.Repositories.Interfaces
{
    public interface IExpensesRepository
    {
        Task<List<Expense>> GetAll();
        Task AddAsync(Expense expense, bool shouldSaveContext = true);
        Task<bool> UpdateAsync(int id, Expense expense);
        Task<bool> DeleteAsync(int id);
    }
}
