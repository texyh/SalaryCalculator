using System;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class SatisfactoryScore : Entity<Guid>
    {
        public int Score {get; set;}

        public DateTime Year { get;set; }

        public Guid EmployeeId { get; set;}

        public virtual Employee Employee { get; set; }
    }
}