using SalaryCalculator.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator.Domain.Helpers
{
    public class Score
    {
        public static double GetAverage(List<SatisfactoryScore> scores)
        {
            if (scores.Count == 1)
            {
                return scores[0].Score;
            }

            scores = scores.OrderByDescending(x => x.Year).Take(3).ToList();
            var avg1 = scores.Skip(1).Average(x => x.Score);
            var avgScore = new List<double> { scores[0].Score, avg1 }.Average();

            return Math.Ceiling(avgScore);
        }
    }
}
