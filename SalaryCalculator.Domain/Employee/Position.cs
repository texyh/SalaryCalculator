using System;
using System.Collections.Generic;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class Position : Entity<Guid>, IEquatable<Position>
    {

        public Position()
        {
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } 

        public virtual ICollection<SalaryCategory> SalaryCategories { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Position);
        }

        public bool Equals(Position other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Id.Equals(other.Id) &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -1488479220;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}