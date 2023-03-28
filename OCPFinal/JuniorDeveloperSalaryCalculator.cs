using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPFinal
{
    public class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDeveloperSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
        }
    }
}
