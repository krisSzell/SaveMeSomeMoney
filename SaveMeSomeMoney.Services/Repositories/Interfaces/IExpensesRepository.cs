using SaveMeSomeMoney.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Services.Repositories.Interfaces
{
    public interface IExpensesRepository
    {
        Task<List<Expense>> GetAll();
    }
}
