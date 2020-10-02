using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore
{
    public class SaveEmployeeSatisfacoryScoreCommandHandler : ISaveEmployeeSatisfactoryCommandHandler
    {
        private readonly ISatisfactoryScoreReposiotry _satisfactoryScoreRepository;

        public SaveEmployeeSatisfacoryScoreCommandHandler(ISatisfactoryScoreReposiotry satisfactoryScoreReposiotry)
        {
            _satisfactoryScoreRepository = satisfactoryScoreReposiotry;
        }

        public async Task<SaveEmployeeSatisfactoryScoreResult> HandleAsync(SaveEmployeeSatisfactoryScoreCommand command)
        {
            if(command.Score > 5)
            {
                return new ErrorResult("Satisfactory score cannot be more than 5");
            }

            await _satisfactoryScoreRepository.Save(new SatisfactoryScore
            {
                Score = command.Score,
                EmployeeId = command.EmployeeId,
                Id = Guid.NewGuid(),
                Year = DateTime.UtcNow
            });

            return new SuccessResult();
        }
    }
}
