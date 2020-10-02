using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Domain.Employee.Commands.SaveEmployeeSatisfactoryScoreCommand
{
    public class SaveEmployeeSatisfactoryScoreCommand
    {
        public int Score { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
