using System;
using System.Collections.Generic;
using System.Text;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Employee : Entity<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Guid PositionId { get; set; }

        public decimal Salary {get; set;}

        public Guid SalaryCategoryId { get; set; }

        public SalaryCategory SalaryCategory {get; set;}

        public Guid ManagerId {get; set;}

        public Employee Manager {get; set;}

        public Position Position {get; set;}

        public virtual ICollection<SatisfactoryScore> SatisfactoryScores {get; set;}
    }
}
