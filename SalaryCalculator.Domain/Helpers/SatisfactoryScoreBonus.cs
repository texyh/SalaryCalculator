using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator.Domain.Helpers
{
    public static class SatisfactoryScoreBonus
    {
        private static IDictionary<int, double> ScoreBonus = new Dictionary<int, double>
        {
            { 0, 0.00 }, { 1, 0.00 },
            { 2, 0.02 }, { 3, 0.07 },
            { 4, 0.15 }, { 5, 0.2}
        };

        public static double GetBonus(int score) => ScoreBonus[score];
    }
}
