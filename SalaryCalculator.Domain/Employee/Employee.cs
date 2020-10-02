using System;
using System.Collections.Generic;
using System.Text;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Employee : Entity<Guid>, IEquatable<Employee>
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

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Id.Equals(other.Id) &&
                   Name == other.Name &&
                   Email == other.Email &&
                   Experience == other.Experience &&
                   PositionId.Equals(other.PositionId) &&
                   SalaryCategoryId.Equals(other.SalaryCategoryId) &&
                   EqualityComparer<Guid?>.Default.Equals(ManagerId, other.ManagerId);
        }

        public override int GetHashCode()
        {
            int hashCode = -782252986;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + Experience.GetHashCode();
            hashCode = hashCode * -1521134295 + PositionId.GetHashCode();
            hashCode = hashCode * -1521134295 + SalaryCategoryId.GetHashCode();
            hashCode = hashCode * -1521134295 + ManagerId.GetHashCode();
            return hashCode;
        }
    }
}
