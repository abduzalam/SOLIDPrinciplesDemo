// See https://aka.ms/new-console-template for more information
using OCPInitial;

Console.WriteLine("OCPInitial!");
// The Open Closed Principle (OCP) is the SOLID principle which states that the software entities (classes or methods)
// should be open for extension but closed for modification.

// We are using a Salary Calculator example here

// In the first time, we have only CalculateTotalSalaries() of all employee level in SalaryCalculator class

var devReports = new List<DeveloperReport>()
{ 
    new DeveloperReport{ Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 },
    new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
    new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
};

var calculator = new SalaryCalculator(devReports);
Console.WriteLine($"Sum of all developer salaries is {calculator.CalculateTotalSalaries()} dollars");

// Assume the above code is in production.

// but now our boss comes to our office and says that we need a different calculation for the senior and junior developers.
// The senior developers should have a bonus of 20% on a salary.

// Of course, to satisfy this requirement, we are going to modify our CalculateTotalSalaries method 