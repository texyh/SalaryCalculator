using System;
using System.Collections.Generic;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class SalaryCategory : Entity<Guid>
    {
        public SalaryCategory()
        {
            Employees = new List<Employee>();
        }

        public string YearsRange { get; set; }

        public Guid PositionId {get; set;}

        public virtual Position Position { get; set; }

        public int Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}