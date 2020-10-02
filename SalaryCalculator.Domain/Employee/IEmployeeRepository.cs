using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.Domain.Employee
{
    public interface IEmployeeRepository
    {
        Task<IList<Employee>> GetAll();
    }
}