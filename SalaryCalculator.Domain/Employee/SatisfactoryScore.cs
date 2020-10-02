using System;
using SalaryCalculator.Domain.Abstractions;

namespace SalaryCalculator.Domain.Employee
{
    public class SatisfactoryScore : Entity<Guid>, IEquatable<SatisfactoryScore>
    {
        public int Score {get; set;}

        public DateTime Year { get;set; }

        public Guid EmployeeId { get; set;}

        public virtual Employee Employee { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SatisfactoryScore);
        }

        public bool Equals(SatisfactoryScore other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Id.Equals(other.Id) &&
                   Score == other.Score &&
                   Year == other.Year &&
                   EmployeeId.Equals(other.EmployeeId);
        }

        public override int GetHashCode()
        {
            int hashCode = 1822066363;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            hashCode = hashCode * -1521134295 + Year.GetHashCode();
            hashCode = hashCode * -1521134295 + EmployeeId.GetHashCode();
            return hashCode;
        }
    }
}