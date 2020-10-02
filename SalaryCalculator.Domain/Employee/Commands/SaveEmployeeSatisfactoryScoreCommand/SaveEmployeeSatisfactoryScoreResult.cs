using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using System.Collections.Generic;

namespace SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand
{
    public abstract class SaveEmployeeSatisfactoryScoreResult
    {

    }

    public class SuccessResult : SaveEmployeeSatisfactoryScoreResult
    {
        public SuccessResult()
        {
        }
    }

    public class ErrorResult : SaveEmployeeSatisfactoryScoreResult
    {
        public ErrorResult(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}