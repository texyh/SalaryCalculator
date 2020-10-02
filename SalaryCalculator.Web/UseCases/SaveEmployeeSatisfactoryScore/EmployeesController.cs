using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;

namespace SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ISaveEmployeeSatisfactoryCommandHandler _handler;

        public EmployeesController(ISaveEmployeeSatisfactoryCommandHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("satisfactory-score")]
        public async Task<IActionResult> SaveEmpoloyeeSatisfactoryScore([FromBody] SaveEmployeeSatisfactoryScoreRequest request)
        {
            SaveEmployeeSatisfactoryScoreCommand command = new SaveEmployeeSatisfactoryScoreCommand 
            {   
                EmployeeId = request.EmployeeId, 
                Score = request.Score 
            };

            return Result.For(await _handler.HandleAsync(command));
        }
    }
}
