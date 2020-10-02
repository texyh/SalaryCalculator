using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SalaryCalculator.Infrastructure;
using Serilog;
using System.Reflection;

namespace SalaryCalculator.Web
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Salary Calculator Api",
                    Version = "v1",
                    Description = "This is an api that allow you view employee with their salaries"
                });
            });

            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContextPool<SalaryCalculatorDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
