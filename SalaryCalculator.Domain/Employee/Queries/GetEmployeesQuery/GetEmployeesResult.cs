using System.Collections.Generic;

namespace SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery
{
    public abstract class GetEmployeesResult
    {

    }

    public class SuccessResult : GetEmployeesResult
    {
        public SuccessResult(IList<EmployeeDetails> employees)
        {
            EmployeeDetails = employees;
        }

        public IList<EmployeeDetails> EmployeeDetails { get; }
    }
}