using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPFinal
{
    public class SeniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        double totalSalary = 0D;
        public SeniorDeveloperSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            totalSalary += DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
            return totalSalary;
        }
    }
}
