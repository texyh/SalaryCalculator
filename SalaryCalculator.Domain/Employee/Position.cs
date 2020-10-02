using System;
using System.Collections.Generic;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Position : Entity<Guid>
    {
        public Position()
        {
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } 

        public virtual ICollection<SalaryCategory> SalaryCategories { get; set; }
    }
}