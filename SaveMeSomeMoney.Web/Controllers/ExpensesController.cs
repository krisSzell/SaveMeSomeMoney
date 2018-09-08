using Microsoft.AspNetCore.Mvc;
using SaveMeSomeMoney.Services.Models;
using SaveMeSomeMoney.Services.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveMeSomeMoney.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesRepository _expensesRepository;

        public ExpensesController(IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Expense>>> GetAll()
        {
            return await _expensesRepository.GetAll();
        }


    }
}
