using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Services.Repositories
{
    public class ExpensesRepository : IExpensesRepository
    {
        private readonly AppDbContext _context;

        public ExpensesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Expense expense, bool shouldSaveContext = true)
        {
            await _context.Expenses.AddAsync(expense);

            if (shouldSaveContext)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var expenseToDelete = await _context.Expenses.FindAsync(id);

            if (expenseToDelete == null)
            {
                return false;
            }

            _context.Expenses.Remove(expenseToDelete);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Expense>> GetAll()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task<bool> UpdateAsync(int id, Expense expense)
        {
            var oldExpense = await _context.Expenses.FindAsync(id);

            if (oldExpense == null)
            {
                return false;
            }

            _context.Entry(oldExpense).CurrentValues.SetValues(expense);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
