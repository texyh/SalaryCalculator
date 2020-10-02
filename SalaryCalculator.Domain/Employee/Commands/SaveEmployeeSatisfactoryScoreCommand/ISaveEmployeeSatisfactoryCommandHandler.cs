using System.Threading.Tasks;

namespace SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand
{
    public interface ISaveEmployeeSatisfactoryCommandHandler
    {
        Task<SaveEmployeeSatisfactoryScoreResult> HandleAsync(SaveEmployeeSatisfactoryScoreCommand command);
    }
}
