using Microsoft.Extensions.DependencyInjection;
using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;
using SalaryCalculator.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore
{
    public static class Dependencies
    {
        public static void AddSaveEmployeeSatisfactoryScoreUseCase(this IServiceCollection services)
        {
            services.AddScoped<ISatisfactoryScoreReposiotry, SatisfactoryScoreRepository>();
            services.AddScoped<ISaveEmployeeSatisfactoryCommandHandler, SaveEmployeeSatisfacoryScoreCommandHandler>();
        }
    }
}
