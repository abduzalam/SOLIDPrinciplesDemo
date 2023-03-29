using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Initial
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByMonitorType(IEnumerable<ComputerMonitor> monitors, MonitorType type) => monitors.Where(m => m.MonitorType == type).ToList();
    }
}
