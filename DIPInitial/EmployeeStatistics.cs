using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPInitial
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _employeeManager;
        public EmployeeStatistics(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int CountFemaleEmployees()
        {
            //Logic goes here
            throw new NotImplementedException();
        }
    }
}


// In the above structure, we can't make use of _employees list in Employee manager class to find the Count of female employees.