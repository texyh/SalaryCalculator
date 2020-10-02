using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SalaryCalculator.Domain.Employee;
using SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery;
using SalaryCalculator.Web.UseCases;
using Xunit;

namespace SalaryCalculator.UnitTests.UseCases.GetEmployees
{
    public class GetEmployeeQueryHandlerShould
    {
        [Fact]
        public async Task Return_EmployeeDetails() 
        {
            var employees = new List<Employee> 
            {
                new Employee 
                {
                    Name = "John doe",
                    Position = new Position 
                    {
                        Name = "Technician"
                    },
                    SatisfactoryScores = new List<SatisfactoryScore> 
                    {
                        new SatisfactoryScore 
                        {
                            Score = 3
                        }
                    },
                    SalaryCategory = new SalaryCategory 
                    {
                        Salary = 2000,
                    }
                }
            };
            var mockRepo = new Mock<IEmployeeRepository>();
            mockRepo.Setup(x => x.GetAll())
                    .ReturnsAsync(employees);
            var sut = new GetEmployeeQueryHandler(mockRepo.Object);
            
            var result = await sut.HandleAsync() as SuccessResult;

            result.EmployeeDetails[0].Name.Should().Be(employees[0].Name);
            result.EmployeeDetails[0].Salary.Should().Be(2940.0);
            result.EmployeeDetails[0].Position.Should().Be(employees[0].Position.Name);

        }
    }
}