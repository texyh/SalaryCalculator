using System;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class SalaryCategory : Entity<Guid>
    {
        public string YearsRange { get; set; }

        public string PositionId {get; set;}

        public Position Position { get; set; }

        public int Salary { get; set; }
    }
}