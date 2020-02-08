using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitsProject.DTO;
using InitsProject.Entities;
using Microsoft.Extensions.Options;

namespace InitsProject.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ExpenseContext _context;
        private readonly VATSetting vatSetting;

        public ExpenseService(ExpenseContext expenseContext, IOptions<VATSetting> options)
        {
            _context = expenseContext;
            vatSetting = options.Value;
        }

        public async Task<bool> AddExpense(ExpenseDTO expense)
        {
            try
            {
                var data = new Expense
                {
                    Value = expense.Value,
                    Reason = expense.Reason,
                    DateOfExpense = expense.Date,
                    DateCreated = DateTime.Now
                };

                data.VAT = ExtractVATFromValue(expense.Value);

                _context.Expenses.Add(data);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<ExpenseDTO>> GetExpenses()
        {
            var expenses = _context.Expenses;
            List<ExpenseDTO> result = (from e in expenses
                                       select new ExpenseDTO
                                       {
                                           Id = e.ExpenseId, 
                                           Reason = e.Reason,
                                           Value = e.Value,
                                           VAT = e.VAT,
                                           Date = e.DateOfExpense
                                       }).ToList();
            return result;
        }

        public decimal ExtractVATFromValue(decimal value)
        {            
            decimal vat = vatSetting.Percentage / 100;
            value *= vat;
            return value;
        }
    }
}
