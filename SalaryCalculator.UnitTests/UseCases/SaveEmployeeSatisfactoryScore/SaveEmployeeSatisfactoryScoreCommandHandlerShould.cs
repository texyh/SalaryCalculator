using Moq;
using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;
using SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SalaryCalculator.UnitTests.UseCases.SaveEmployeeSatisfactoryScore
{
    public class SaveEmployeeSatisfactoryScoreCommandHandlerShould
    {

        [Fact]
        public async Task Save_Employee_SatisfactoryScore()
        {
            var mockRepo = new Mock<ISatisfactoryScoreReposiotry>();
            var sut = new SaveEmployeeSatisfacoryScoreCommandHandler(mockRepo.Object);

            var result = await sut.HandleAsync(new SaveEmployeeSatisfactoryScoreCommand 
            {
                EmployeeId = Guid.NewGuid(),
                Score = 3
            });

            mockRepo.Verify(x => x.Save(It.IsAny<SatisfactoryScore>()), Times.Once);
        }

        [Fact]
        public async Task Not_Save_Employee_SatisfactoryScore_If_Score_IsGreaterThan_Five()
        {
            var mockRepo = new Mock<ISatisfactoryScoreReposiotry>();
            var sut = new SaveEmployeeSatisfacoryScoreCommandHandler(mockRepo.Object);

            var result = await sut.HandleAsync(new SaveEmployeeSatisfactoryScoreCommand
            {
                EmployeeId = Guid.NewGuid(),
                Score = 9
            });

            mockRepo.Verify(x => x.Save(It.IsAny<SatisfactoryScore>()), Times.Never);
        }
    }
}
