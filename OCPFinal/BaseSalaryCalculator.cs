using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OCPFinal;

public abstract class BaseSalaryCalculator
{
    protected DeveloperReport DeveloperReport { get; private set; }

    public BaseSalaryCalculator(DeveloperReport developerReport)
    {
        DeveloperReport = developerReport;
    }

    public abstract double CalculateSalary();
}
