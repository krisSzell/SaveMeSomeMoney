using Microsoft.AspNetCore.Mvc;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Web.Expenses
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesRepository _expensesRepository;

        public ExpensesController(IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        [HttpGet]
        [Route("api/[controller]/all")]
        public async Task<ActionResult<List<Expense>>> GetAllAsync()
        {
            return await _expensesRepository.GetAll();
        }

        [HttpPost]
        [Route("api/[controller]/add")]
        public IActionResult Add([FromBody] Expense expense)
        {
            _expensesRepository.Add(expense);

            return Ok(expense);
        }
    }
}
