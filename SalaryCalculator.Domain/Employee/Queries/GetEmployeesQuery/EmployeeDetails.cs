using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Domain.Employee.Queries.GetEmployeesQuery
{
    public class EmployeeDetails
    {
        public Guid Id { get; set;}

        public string Name { get; set; }

        public string Email { get; set; }

        public int Experience { get; set; } /// years in company

        public string  Position { get; set; }

        public double Salary { get; set; }
    }
}
