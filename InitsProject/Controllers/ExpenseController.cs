using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitsProject.DTO;
using InitsProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitsProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService expenseService;
        public ExpenseController(IExpenseService expense)
        {
            expenseService = expense;
        }
        
        [Produces(typeof(ResponseMessage))]
        [Route("")]
        [HttpPost]
        public async Task<IActionResult> AddNewExpense([FromBody] ExpenseDTO expenseDTO)
        {
            if (ModelState.IsValid)
            {
                var resp = await expenseService.AddExpense(expenseDTO);
                if (resp)
                {
                    return Ok(new ResponseMessage
                    {
                        status = "success",
                        data = new { id = expenseDTO.Id }
                    });
                }
                else
                {
                    return Ok(new ResponseMessage
                    {
                        status = "failed"
                    });
                }
            }
            else
            {
                var errors = ModelState.Values.Select(cx => cx.Errors?.FirstOrDefault()?.ErrorMessage);
                return Ok(new ResponseMessage
                {
                    status = "failed",
                    ErrorMessages = errors.ToList()
                });
            }
        }

        [Produces(typeof(List<ExpenseDTO>))]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            try
            {
                var expenses = await expenseService.GetExpenses();
                return Ok(expenses);
            }
            catch (Exception ex)
            {
                return Ok(new ResponseMessage
                {
                    status = "failed",
                    ErrorMessages = new List<string> { ex.Message }
                });
            }
        }
    }
}