using System.Threading.Tasks;

namespace SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery
{
    public interface IGetEmployeesQueryHandler
    {
        Task<GetEmployeesResult> HandleAsync();
    }
}