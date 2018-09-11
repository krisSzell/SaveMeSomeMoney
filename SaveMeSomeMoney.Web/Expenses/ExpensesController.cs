using Microsoft.AspNetCore.Mvc;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Web.Expenses
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesRepository _expensesRepository;

        public ExpensesController(IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        [HttpGet]
        [Route("/api/expenses/all")]
        public async Task<ActionResult<List<Expense>>> GetAllAsync()
        {
            return await _expensesRepository.GetAll();
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Route("/api/expenses/add")]
        public async Task<ActionResult<Expense>> AddAsync(Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _expensesRepository.AddAsync(expense);

            return CreatedAtAction(nameof(AddAsync), expense);
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [Route("/api/expenses/{id}/update")]
        public async Task<ActionResult<Expense>> Update(int id, Expense expense)
        {
            if (!await _expensesRepository.UpdateAsync(id, expense))
            {
                return new NotFoundResult();
            }

            return expense;
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [Route("/api/expenses/{id}/delete")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (!await _expensesRepository.DeleteAsync(id))
            {
                return new NotFoundResult();
            }

            return new OkResult();
        }
    }
}
