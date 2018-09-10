using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Services.Repositories
{
    public class ExpensesRepository : IExpensesRepository
    {
        private readonly IAppDbContext _context;

        public ExpensesRepository(IAppDbContext context)
        {
            _context = context;
        }

        public void Add(Expense expense, bool shouldSaveContext = true)
        {
            _context.Expenses.Add(expense);

            if (shouldSaveContext)
            {
                _context.SaveChanges();
            }
        }

        public async Task<List<Expense>> GetAll()
        {
            return await _context.Expenses.ToListAsync();
        }
    }
}
