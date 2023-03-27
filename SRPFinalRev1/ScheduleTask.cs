using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinalRev1
{
    public class ScheduleTask
    {
        public int TaskId { get; set; }
        public string? Content { get; set; }
        public DateTime? ExecuteOn { get; set; }
    }
}
