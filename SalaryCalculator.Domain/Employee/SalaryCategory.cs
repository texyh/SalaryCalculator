using System;
using System.Collections.Generic;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class SalaryCategory : Entity<Guid>, IEquatable<SalaryCategory>
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

        public override bool Equals(object obj)
        {
            return Equals(obj as SalaryCategory);
        }

        public bool Equals(SalaryCategory other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Id.Equals(other.Id) &&
                   YearsRange == other.YearsRange &&
                   PositionId.Equals(other.PositionId) &&
                   Salary == other.Salary;
        }

        public override int GetHashCode()
        {
            int hashCode = 1117201298;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(YearsRange);
            hashCode = hashCode * -1521134295 + PositionId.GetHashCode();
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            return hashCode;
        }
    }
}