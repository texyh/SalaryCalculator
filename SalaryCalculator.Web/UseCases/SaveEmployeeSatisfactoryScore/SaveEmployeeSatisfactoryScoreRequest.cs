using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryCalculator.Web.UseCases.SaveEmployeeSatisfactoryScore
{
    public class SaveEmployeeSatisfactoryScoreRequest
    {
        [Required]
        public int Score { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }
    }
}