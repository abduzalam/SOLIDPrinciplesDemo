// See https://aka.ms/new-console-template for more information
using OCPFinal;

Console.WriteLine("OCPFinal");
var devCalculations = new List<BaseSalaryCalculator>
        {
            new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
            new JuniorDeveloperSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
            new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 }),
            new ManagerSalaryCalculator(new DeveloperReport {Id = 3, Name = "Mgr1", Level = "Manager", HourlyRate = 31, WorkingHours = 180 })
        };
var calculator = new SalaryCalculator(devCalculations);
Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
