using Microsoft.EntityFrameworkCore;
using SaveMeSomeMoney.Services.Models;

namespace SaveMeSomeMoney.Services.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        public DbSet<Income> Incomes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseCategory>()
                .HasIndex(ec => ec.Name)
                .IsUnique(true);
        }
    }
}
