using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore
{
    public class Result
    {
        public static IActionResult For(SaveEmployeeSatisfactoryScoreResult result)
        {
            return result switch
            {
                SuccessResult s => new StatusCodeResult((int)HttpStatusCode.Created),
                ErrorResult s => new BadRequestObjectResult(s.Message),
                _ => new StatusCodeResult((int)HttpStatusCode.InternalServerError)
            };
        }
    }
}
