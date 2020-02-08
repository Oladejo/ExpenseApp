using System;

namespace InitsProject.Entities
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public decimal Value { get; set; }
        public string Reason { get; set; }
        public decimal VAT { get; set; }
        public DateTime DateOfExpense { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
