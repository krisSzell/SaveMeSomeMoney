﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaveMeSomeMoney.Services.Models
{
    public class Expense : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string ExpenseCategoryId { get; set; }

        [JsonIgnore]
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
