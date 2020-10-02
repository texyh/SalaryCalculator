using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases.GetEmployees
{
    public class Result
    {
        public static IActionResult For(GetEmployeesResult result)
        {
            return result switch
            {
                SuccessResult success => new OkObjectResult(success.EmployeeDetails),
                _ => InternalServerError()
            };
        }

        private static StatusCodeResult InternalServerError()
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}
