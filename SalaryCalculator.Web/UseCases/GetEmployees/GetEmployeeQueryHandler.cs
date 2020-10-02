using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using SalaryCalculator.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases
{
    public class GetEmployeeQueryHandler : IGetEmployeesQueryHandler
    { 
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<GetEmployeesResult> HandleAsync()
        {
            var employees = await _employeeRepository.GetAll();
            var employeeDetails = new List<EmployeeDetails>();

            foreach (var employee in employees)
            {
                var baseSalary = employee.SalaryCategory.Salary;
                var avgSatisfactoryScrore = Score.GetAverage(employee.SatisfactoryScores.ToList());
                var bonus = SatisfactoryScoreBonus.GetBonus((int)avgSatisfactoryScrore);
                var salary = baseSalary + (baseSalary * bonus) + Wage.Minimum;

                employeeDetails.Add(new EmployeeDetails
                {
                    Id = employee.Id,
                    Email = employee.Email,
                    Experience = employee.Experience,
                    Name = employee.Name,
                    Position = employee.Position.Name,
                    Salary = salary
                });
            }

            return new SuccessResult(employeeDetails);
        }
    }
}