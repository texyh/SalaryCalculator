using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;

namespace SalaryCalculator.Web.UseCases.GetEmployees
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IGetEmployeesQueryHandler _handler;

        public EmployeesController(IGetEmployeesQueryHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Result.For(await _handler.HandleAsync());
        }
    }
}
