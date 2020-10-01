using System;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Position : Entity<Guid>
    {
        public string Name { get; set; }
    }
}