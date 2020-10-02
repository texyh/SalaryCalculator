using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand;
using SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SalaryCalculator.UnitTests.UseCases.SaveEmployeeSatisfactoryScore
{
    public class EmployeesControllerShould
    {
        [Fact]
        public async Task Save_Employee_SatisfactoryScore()
        {
            var mock = new Mock<ISaveEmployeeSatisfactoryCommandHandler>();
            mock.Setup(x => x.HandleAsync(It.IsAny<SaveEmployeeSatisfactoryScoreCommand>()))
                .ReturnsAsync(new SuccessResult());
                
            var sut = new EmployeesController(mock.Object);

            var response = await sut.SaveEmpoloyeeSatisfactoryScore(new SaveEmployeeSatisfactoryScoreRequest
            {
                EmployeeId = Guid.NewGuid(),
                Score = 4
            });

            var httpResponse = response as StatusCodeResult;
            httpResponse.StatusCode.Should().Be(StatusCodes.Status201Created);
        }

        [Fact]
        public async Task Return_Error_When_Score_IsGreaterThan_Five()
        {
            var mock = new Mock<ISaveEmployeeSatisfactoryCommandHandler>();
            mock.Setup(x => x.HandleAsync(It.IsAny<SaveEmployeeSatisfactoryScoreCommand>()))
                .ReturnsAsync(new ErrorResult("Satisfactory score cannot be more than 5"));
            var sut = new EmployeesController(mock.Object);

            var response = await sut.SaveEmpoloyeeSatisfactoryScore(new SaveEmployeeSatisfactoryScoreRequest
            {
                EmployeeId = Guid.NewGuid(),
                Score = 9
            });

            var httpResponse = response as BadRequestObjectResult;
            httpResponse.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
            httpResponse.Value.Should().Be("Satisfactory score cannot be more than 5");
        }
    }
}
