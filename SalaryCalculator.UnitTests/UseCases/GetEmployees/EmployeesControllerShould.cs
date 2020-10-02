using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using SalaryCalculator.Web.UseCases.GetEmployees;
using System.Collections.Generic;
using System.IO.Compression;
using System.Threading.Tasks;
using Xunit;

namespace SalaryCalculator.UnitTests.UseCases.GetEmployees
{
    public class EmployeesControllerShould
    {
        [Fact]
        public async Task GetEmployees_Details_With_Salary() 
        {
            var employees = new List<EmployeeDetails> 
            {
                new EmployeeDetails 
                {
                    Name = "John Doe",
                    Salary = 2200
                }
            };
            var handler = new Mock<IGetEmployeesQueryHandler>();
            handler.Setup(x => x.HandleAsync())
                .ReturnsAsync(new SuccessResult(employees));
            var sut = new EmployeesController(handler.Object);

            var response = await sut.GetAll();

            var httpResponse = response as OkObjectResult;
            var result = httpResponse.Value  as IList<EmployeeDetails>;
            httpResponse.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Should().HaveCount(1);
            result[0].Name.Should().Be(employees[0].Name);
            result[0].Salary.Should().Be(employees[0].Salary);
        }
    }
}