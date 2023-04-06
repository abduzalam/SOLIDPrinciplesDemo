using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPInitial
{
    // This is our low-lvel class which keeps track of employees
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;

        public EmployeeManager(List<Employee> employees)
        {
            _employees = employees;    
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
