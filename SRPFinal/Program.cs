// See https://aka.ms/new-console-template for more information
using SRPFinal;

Console.WriteLine("SRPFinal - Main Code");
WorkReport workReport = new WorkReport
{
    WorkReportEntries = new List<WorkReportEntry>(),
};

List<WorkReportEntry> entries = new List<WorkReportEntry> { new WorkReportEntry() {  ProjectCode="ABC", ProjectName="N1", SpentHours=8} };
workReport.WorkReportEntries.AddRange(entries);

//workReport.WorkReportEntries = entries; // This is not acceptable due to Init
workReport.AddEntry(new WorkReportEntry { ProjectCode = "123A", ProjectName = "Project1", SpentHours = 5 });
workReport.AddEntry(new WorkReportEntry { ProjectCode = "945A", ProjectName = "Project2", SpentHours = 3 });

Console.WriteLine(workReport.ToString());
FileSaver fileSaver = new FileSaver();
fileSaver.SaveToFile(Directory.GetCurrentDirectory(), "report1.txt");

//Now look at the Better enhanced version of SRP implementatation in SRPFinalRev1 project