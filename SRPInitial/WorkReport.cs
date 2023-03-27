using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SRPInitial
{
    /// <summary>
    ///  public List<WorkReportEntry>? WorkReportEntries { get; init; }
    //   Init avoid the following code and can directly use the constructor code format in out main program

    /*  private readonly List<WorkReport>? _workReportEntries;
      public WorkReport(List<WorkReport> workReportEntries)
      {
          _workReportEntries = workReportEntries;   
      }
    */
    /// </summary>
    /*public class WorkReport
    {
        public List<WorkReportEntry>? WorkReportEntries { get; init; }

        public void AddEntry(WorkReportEntry entry) => WorkReportEntries.Add(entry);

        public void RemoveEntryAt(int index) => WorkReportEntries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, WorkReportEntries
            .Select(x => $"Code : {x.ProjectCode}, Name : {x.ProjectName}, Hours : {x.SpentHours}" ));
       
    }*/

    // Look at the commented code above, Now we need to add a new feature to store the details to a file, so we are adding the
    // SaveToFile method inside WorkReport class like below ( This violates SRP because we are modifying the code already running in prod env)

    public class WorkReport
    {
        public List<WorkReportEntry>? WorkReportEntries { get; init; }

        public void AddEntry(WorkReportEntry entry) => WorkReportEntries.Add(entry);

        public void RemoveEntryAt(int index) => WorkReportEntries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, WorkReportEntries
            .Select(x => $"Code : {x.ProjectCode}, Name : {x.ProjectName}, Hours : {x.SpentHours}"));

        public void SaveToFile(string directoryName, string fileName)
        {
            if(Directory.Exists(directoryName) == false)
            {
                Directory.CreateDirectory(directoryName);
            }
            File.WriteAllText(Path.Combine(directoryName,fileName), ToString());
        }

    }
}
