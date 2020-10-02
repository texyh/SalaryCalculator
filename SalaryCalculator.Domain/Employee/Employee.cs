using System;
using System.Collections.Generic;
using System.Text;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Employee : Entity<Guid>
    {

        public Employee()
        {
            SatisfactoryScores = new List<SatisfactoryScore>();
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Experience { get; set; } /// years in company

        public Guid PositionId { get; set; }

        public Guid SalaryCategoryId { get; set; }

        public Guid? ManagerId { get; set; }

        public virtual Employee Manager { get; set; }

        public virtual Position Position { get; set; }

        public virtual SalaryCategory SalaryCategory { get; set; }

        public virtual ICollection<SatisfactoryScore> SatisfactoryScores {get; set;}
    }
}
