using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPInitial
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;
        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        /// <summary>
        /// The commented CalculateTotalSalaries is the initial version
        /// </summary>
        /// <returns></returns>
        //public double CalculateTotalSalaries()
        //{
        //    double totalSalaries = 0D;

        //    foreach (var devReport in _developerReports)
        //    {
        //        totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
        //    }
        //    return totalSalaries;
        //}



        // Even though this solution is going to give us the correct result, this is not an optimal solution.
        // Mainly, because we had to modify our existing class behavior which worked perfectly.
        // Another thing is that if our boss comes again and ask us to modify calculation for the junior dev’s as well,
        // we would have to change our class again. This is totally against of what OCP stands for.
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                if(devReport.Level == "Senior developer")
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                else
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }
            return totalSalaries;
        }
    }
}
