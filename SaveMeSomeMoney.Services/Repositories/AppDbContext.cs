using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;

namespace SaveMeSomeMoney.Services.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
