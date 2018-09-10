using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;

namespace SaveMeSomeMoney.Services.Repositories.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Expense> Expenses { get; set; }

        void SaveChangesAsync();

        int SaveChanges();
    }
}
