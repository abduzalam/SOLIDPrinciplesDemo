using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinalRev1
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        public List<WorkReportEntry>? WorkReportEntries { get; init; }

        public void AddEntry(WorkReportEntry entry) => WorkReportEntries.Add(entry);

        public void RemoveEntryAt(int index) => WorkReportEntries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, WorkReportEntries
            .Select(x => $"Code : {x.ProjectCode}, Name : {x.ProjectName}, Hours : {x.SpentHours}"));
    }
}
