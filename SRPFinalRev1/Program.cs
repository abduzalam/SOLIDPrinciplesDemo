// See https://aka.ms/new-console-template for more information
using SRPFinalRev1;

Console.WriteLine("This version is even better compared to SRPFinal!");
//Here we are using Generics to Add WorkReport as well and a Scheduler task using SRP principle

// Here addEntry and RemoveEntry are common for both WorkReport and Scheduler task, 
// So we are creating a Generic interface with Add & remove and implements it in both WorkReport and Scheduler classes

// We are also re-using the SaveToFile method to store the workreport and scheduler details to a file
WorkReport report = new WorkReport
{
    WorkReportEntries = new List<WorkReportEntry>(),
};
report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
var scheduler = new Scheduler();
scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });
Console.WriteLine("******************************************************************************************************");
Console.WriteLine(report.ToString());
Console.WriteLine("******************************************************************************************************");
Console.WriteLine(scheduler.ToString());
Console.WriteLine("******************************************************************************************************");
var saver = new FileSaver();
saver.SaveToFile(@"Reports", "WorkReport.txt", report);
saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);

Console.WriteLine("******************************************************************************************************");
Console.WriteLine(scheduler.ToString());
Console.WriteLine("******************************************************************************************************");

