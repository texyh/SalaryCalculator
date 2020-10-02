using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Domain.Employee
{
    public interface ISatisfactoryScoreReposiotry
    {
        Task Save(SatisfactoryScore satisfactoryScore);
    }
}
