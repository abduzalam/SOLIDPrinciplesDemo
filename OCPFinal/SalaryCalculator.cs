using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPFinal
{
    public class SalaryCalculator
    {
        private readonly List<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(List<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var dev in _developerCalculation)
            {
                totalSalaries += dev.CalculateSalary();
            }
            return totalSalaries;
        }
    }
}
