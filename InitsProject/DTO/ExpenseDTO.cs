using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace InitsProject.DTO
{
    public class ExpenseDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        [Required(ErrorMessage = "Required Expense value")]
        public decimal Value { get; set; }

        [JsonProperty("reason")]
        [Required(ErrorMessage = "Required Reason for the expense")]
        public string Reason { get; set; }

        [JsonProperty("DateofExpense")]
        [Required(ErrorMessage = "Require date of the expense")]
        public DateTime Date { get; set; }

        [JsonProperty("vat")]
        public decimal VAT { get; set; }
    }
}
