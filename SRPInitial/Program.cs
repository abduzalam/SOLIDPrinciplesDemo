using SRPInitial;

internal class Program
{
    private static void Main(string[] args)
    {
        WorkReport workReport = new WorkReport
        {
            WorkReportEntries = new List<WorkReportEntry>(),
        };

        workReport.AddEntry(new WorkReportEntry { ProjectCode = "123A", ProjectName = "Project1", SpentHours = 5 });
        workReport.AddEntry(new WorkReportEntry { ProjectCode = "945A", ProjectName = "Project2", SpentHours = 3 });

        Console.WriteLine(workReport.ToString());
        //assume the below code added at a later stage
        workReport.SaveToFile(Directory.GetCurrentDirectory(), "report1.txt");

        //Now look at SRPFinal code
    }
}