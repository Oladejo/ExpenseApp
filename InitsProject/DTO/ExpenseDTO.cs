using System;

namespace InitsProject.DTO
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public decimal VAT { get; set; }
    }
}
