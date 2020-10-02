using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Domain.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SalaryCalculatorDbContext _dbContext;

        public EmployeeRepository(SalaryCalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await _dbContext.Employees
                .Include(x => x.SalaryCategory)
                .Include(x => x.Position)
                .Include(x => x.SatisfactoryScores)
                .ToListAsync();
        }
    }
}