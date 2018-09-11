namespace SaveMeSomeMoney.Services.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }

        public ExpenseCategory ExpenseCategory { get; set; }
        public int ExpenseCategoryId { get; set; }
    }
}
