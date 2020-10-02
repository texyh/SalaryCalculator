using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using SalaryCalculator.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases.GetEmployees
{
    public static class Dependencies
    {
        public static void AddGetEmployeesUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetEmployeesQueryHandler, GetEmployeeQueryHandler>();
            services.TryAddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
