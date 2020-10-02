using SalaryCalculator.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Infrastructure.Repositories
{
    public class SatisfactoryScoreRepository : ISatisfactoryScoreReposiotry
    {
        private readonly SalaryCalculatorDbContext _dbContext;

        public SatisfactoryScoreRepository(SalaryCalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Task Save(SatisfactoryScore satisfactoryScore)
        {
            _dbContext.SatisfactoryScores.Add(satisfactoryScore);
            return _dbContext.SaveChangesAsync();
        }
    }
}
