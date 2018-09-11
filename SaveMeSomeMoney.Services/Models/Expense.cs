using Newtonsoft.Json;

namespace SaveMeSomeMoney.Services.Models
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string ExpenseCategoryId { get; set; }

        [JsonIgnore]
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
