using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinal
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
    // a new class FileSaver and add a new method SaveToFile ( note, we removed SaveToFile method from WorkReport class in this version of WorkReport class)

    public class WorkReport
    {
        public List<WorkReportEntry>? WorkReportEntries { get; init; }

        public void AddEntry(WorkReportEntry entry) => WorkReportEntries.Add(entry);

        public void RemoveEntryAt(int index) => WorkReportEntries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, WorkReportEntries
            .Select(x => $"Code : {x.ProjectCode}, Name : {x.ProjectName}, Hours : {x.SpentHours}"));



    }
}
