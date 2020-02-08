using InitsProject.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InitsProject.Services
{
    public interface IExpenseService
    {
        Task<bool> AddExpense(ExpenseDTO expense);
        Task<List<ExpenseDTO>> GetExpenses();
    }
}
