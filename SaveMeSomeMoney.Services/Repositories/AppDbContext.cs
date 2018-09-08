using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;

namespace SaveMeSomeMoney.Services.Repositories
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
